using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.Win32;
using CCWin.Win32.Const;
using System.Diagnostics;
using System.Configuration;
using ESBasic.Security;
using ESPlus.Rapid;
using CCWin.SkinControl;
using ESBasic;
using JustLib;
using JustLib.Controls;
using JustLib.Records;
using ESPlus.Serialization;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace GGTalk
{


    public partial class GroupFileForm : BaseForm
    {
        private IGroupFilePersister remotePersister;
        private IChatRecordPersister localPersister;
        private int totalPageCount = 1;
        private int currentPageIndex = -1;
        private int pageSize = 25;
        private Parameter<string, string> my; //ID - Name
        private Parameter<string, string> friend;
        private Parameter<string, string> group;
        private bool isGroupChat = false;
        private IUserNameGetter userNameGetter;

        private IRapidPassiveEngine rapidPassiveEngine;
        private IGroup ggSupporter;


        public GroupFileForm(IGroupFilePersister remote, Parameter<string, string> gr, Parameter<string, string> _my, IUserNameGetter getter, IRapidPassiveEngine engine, IGroup supporter)
        {
            InitializeComponent();


            this.listView1.View = View.Details;
            //   ListView listView1 = new ListView();
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes. 是否显示复选框
            listView1.CheckBoxes = false;
            // Select the item and subitems when selection is made. 是否选中整行
            listView1.FullRowSelect = true;
            // Display grid lines. 是否显示网格
            listView1.GridLines = true;
            // Sort the items in the list in ascending order. 升序还是降序
            listView1.Sorting = SortOrder.Ascending;

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 36);//分别是宽和高

            listView1.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大

            this.listView1.Columns.Add("编号", 60, HorizontalAlignment.Left);
            this.listView1.Columns.Add("文件名称", 360, HorizontalAlignment.Left);
            this.listView1.Columns.Add("大小", 80, HorizontalAlignment.Left);
            this.listView1.Columns.Add("上传人", 120, HorizontalAlignment.Left);
            this.listView1.Columns.Add("上传日期", 160, HorizontalAlignment.Left);
            this.listView1.Visible = true;

            this.isGroupChat = true;
            this.group = gr;
            this.my = _my;
            this.userNameGetter = getter;
            this.Text = "群文件 - " + gr.Arg2;
            this.remotePersister = remote;

            this.rapidPassiveEngine = engine;
            this.ggSupporter = supporter;




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Title = "打开文件";
            oFD.ShowHelp = true;
            oFD.Filter = "所有文件|*.*|文本文件|*.txt|RTF文件|*.rtf";//过滤格式
            oFD.FilterIndex = 1;                                    //格式索引
            oFD.RestoreDirectory = false;
            oFD.InitialDirectory = "c:\\";                          //默认路径
            oFD.Multiselect = false;                                 //是否多选
            if (oFD.ShowDialog() == DialogResult.OK)
            {


                SendFile(ConfigurationManager.AppSettings["ServerIP"], int.Parse(ConfigurationManager.AppSettings["ServerSocketPort"].ToString()), oFD.FileName, this.group.Arg1);
            }

        }

        static Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void SendFile(string serverIP, int port, string filePath, string Group)
        {

            if (!sock.Connected)

            { sock.Connect(new IPEndPoint(IPAddress.Parse(serverIP), port)); }
            try
            {
                using (FileStream reader = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    long send = 0L, length = reader.Length;
                    string sendStr = "namelength|" + Path.GetFileName(filePath) + "|" + length.ToString() + "|" + Group;

                    string fileName = Path.GetFileName(filePath);
                    sock.Send(Encoding.Default.GetBytes(sendStr));

                    int BufferSize = 1024;
                    byte[] buffer = new byte[32];
                    sock.Receive(buffer);
                    string mes = Encoding.Default.GetString(buffer);

                    if (mes.Contains("OK"))
                    {
                        byte[] fileBuffer = new byte[BufferSize];
                        int read, sent;
                        while ((read = reader.Read(fileBuffer, 0, BufferSize)) != 0)
                        {
                            sent = 0;
                            while ((sent += sock.Send(fileBuffer, sent, read, SocketFlags.None)) < read)
                            {
                                send += (long)sent;
                            }
                        }
                        //写入记录

                        FileInfo fileInfo = new FileInfo(filePath);
                        SendGroupFileContract contract = new SendGroupFileContract(Guid.NewGuid().ToString().Replace("-", "").ToUpper(), fileInfo.Name, fileInfo.Length, this.rapidPassiveEngine.CurrentUserID, this.my.Arg2,

                          DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Group
                            );

                        byte[] bRes = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.SendGroupFile, CompactPropertySerializer.Default.Serialize(contract));

                        SendGroupFileResult res = (SendGroupFileResult)BitConverter.ToInt32(bRes, 0);

                        if (res == 0)
                        {
                            MessageBox.Show("上传成功！");
                            BindingData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }


        }


        private void BindingData()
        {

            if (this.remotePersister.GetAllGroupFile(this.group.Arg1) != null)
            {
                int i = 0;
                this.listView1.Items.Clear();
                foreach (GroupFile f in this.remotePersister.GetAllGroupFile(this.group.Arg1))

                {
                    i++;
                    ListViewItem li = new ListViewItem();
                    li.SubItems[0].Text = i.ToString();
                    li.SubItems.Add(f.FileName).Tag = f.SID;
                    li.SubItems.Add(GetLength(f.FileLength));
                    li.SubItems.Add(f.SenderName).Tag = f.SenderID;
                    li.SubItems.Add(f.SendDate);
                    this.listView1.Items.Add(li);

                }
            }

        }



        private string GetLength(long l)

        {
            string ret = l.ToString() + "B";
            if (l > 1024)

            {

                ret = (l / 1024) + "K";
            }

            if (l > 1024 * 1024)

            {

                ret = (l / 1024 * 1024) + "M";
            }
            return ret;



        }


        private void NoticeRecordForm_Load(object sender, EventArgs e)
        {
            BindingData();
        }

        string filepach = System.AppDomain.CurrentDomain.BaseDirectory + @"FileDown\";
        private void button1_Click(object sender, EventArgs e)
        {

            DownFile("营业部客户分析.xls");
        }


        private void DownFile(string FileName)

        {

            if (!sock.Connected)

            { sock.Connect(new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ServerIP"]), int.Parse(ConfigurationManager.AppSettings["ServerSocketPort"].ToString()))); }
            string sendStr = "downfile|" + FileName + "|" + this.group.Arg1 + "|" + this.my.Arg1;
            sock.Send(Encoding.Default.GetBytes(sendStr));
            byte[] buffer = new byte[32];
            sock.Receive(buffer);
            string mes = Encoding.Default.GetString(buffer);

            if (mes.Contains("OK"))
            {

                long length = Convert.ToInt64(mes.Split('|')[1]);
                long receive = 0L;

                filepach = filepach + this.my.Arg1;
                if (!System.IO.Directory.Exists(filepach))
                {
                    System.IO.Directory.CreateDirectory(filepach);
                }
                using (FileStream writer = new FileStream(Path.Combine(filepach, FileName), FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    int received;
                    while (receive < length)
                    {
                        received = sock.Receive(buffer);
                        writer.Write(buffer, 0, received);
                        writer.Flush();
                        receive += (long)received;
                    }

                    if (receive >= length)
                    {
                        MessageBox.Show("下载成功！");
                    }
                }
            }



        }


        private void DeleteFile(string FileID, string groupID)

        {
            byte[] bRes = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.DeleteGroupFile, System.Text.Encoding.UTF8.GetBytes(FileID + "|" + groupID));

            DeleteGroupFileResult res = (DeleteGroupFileResult)BitConverter.ToInt32(bRes, 0);
            if (res == 0)
            {
                MessageBox.Show("删除成功！");
                BindingData();
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }
        event EventHandler MenuItem_Click;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                if (listView1.SelectedItems != null)
                {
                    string filename = listView1.SelectedItems[0].SubItems[1].Text;
                    string sid = listView1.SelectedItems[0].SubItems[1].Tag.ToString();
                    string sendid = listView1.SelectedItems[0].SubItems[3].Tag.ToString();

                    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                    ToolStripMenuItem MenuItem0 = new ToolStripMenuItem("下载");
                    ToolStripMenuItem MenuItem1 = new ToolStripMenuItem("删除");
                    MenuItem_Click = (obj, arg) =>
                   {
                       string ItemName = ((ToolStripMenuItem)obj).AccessibilityObject.Name;
                       try
                       {
                           switch (ItemName)
                           {
                               case "下载":

                                   DownFile(filename);

                                   break;

                               case "删除":
                                   DeleteFile(sid, this.ggSupporter.ID);

                                   break;
                           }

                       }
                       catch (Exception ee)
                       {
                           MessageBoxEx.Show("请求超时！" + ee.Message, GlobalResourceManager.SoftwareName);
                       }



                   };
                    MenuItem0.Click += new EventHandler(MenuItem_Click);
                    MenuItem1.Click += new EventHandler(MenuItem_Click);
                    contextMenuStrip.Items.Add(MenuItem0);

                    if (this.ggSupporter.CreatorID == this.my.Arg1 || this.ggSupporter.ManagerList.Contains(this.my.Arg1)|| sendid== this.my.Arg1)
                    { contextMenuStrip.Items.Add(MenuItem1); }


                    contextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);

                }




            }


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
