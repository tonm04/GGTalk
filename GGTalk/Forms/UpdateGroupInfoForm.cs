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
using ESBasic;

using ESPlus.Application.CustomizeInfo;
using ESPlus.Application;
using GGTalk;

namespace GGTalk
{
    public partial class UpdateGroupInfoForm : BaseForm
    {
        private int headImageIndex = 0;
        private IRemotingService ggService;
        private GGGroup currentGroup;
        private IRapidPassiveEngine rapidPassiveEngine;
        public event CbGeneric<GGGroup> GroupInfoChanged;
        GlobalUserCache globalUserCache;
        public UpdateGroupInfoForm(IRapidPassiveEngine engine, GlobalUserCache cache, GGGroup group)
        {
            InitializeComponent();

            this.rapidPassiveEngine = engine;
            this.currentGroup = group;
            int registerPort = int.Parse(ConfigurationManager.AppSettings["RemotingPort"]);
            this.ggService = (IRemotingService)Activator.GetObject(typeof(IRemotingService), string.Format("tcp://{0}:{1}/RemotingService", ConfigurationManager.AppSettings["ServerIP"], registerPort)); ;

            this.skinLabel_ID.Text = group.ID;
            this.skinTextBox_nickName.SkinTxt.Text = group.Name;
            this.skinTextBox_signature.SkinTxt.Text = group.Announce;

            globalUserCache = cache;

             
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //0923
                if (!this.rapidPassiveEngine.Connected)
                {
                    this.toolTip1.Show("离线状态，无法修改资料。", this.btnRegister, new Point(this.btnRegister.Width / 2, -this.btnRegister.Height), 3000);
                    return;
                }


                if (this.skinTextBox_nickName.SkinTxt.Text.Trim().Length == 0)
                {

                    MessageBoxEx.Show("群名称不能为空！");
                    return;
                }



                this.currentGroup.Name = this.skinTextBox_nickName.SkinTxt.Text;
                this.currentGroup.Announce = this.skinTextBox_signature.SkinTxt.Text;


                //0923
                this.Cursor = Cursors.WaitCursor;
                UIResultHandler handler = new UIResultHandler(this, this.UpdateCallback);
                byte[] data = ESPlus.Serialization.CompactPropertySerializer.Default.Serialize(this.currentGroup);
                //回复异步调用，避免阻塞UI线程
                this.rapidPassiveEngine.SendMessage(null, InformationTypes.UpdateGroupInfo, data, null, 2048, handler.Create(), null); //0924               
            }
            catch (Exception ee)
            {
                this.Cursor = Cursors.Default;
                this.toolTip1.Show("修改失败！" + ee.Message, this.btnRegister, new Point(this.btnRegister.Width / 2, -this.btnRegister.Height), 3000);
            }

        }

        //0923
        private void UpdateCallback(bool acked, object tag)
        {
            this.Cursor = Cursors.Default;
            if (acked)
            {
                MessageBox.Show("修改成功！");

                globalUserCache.UpdateGroup(this.currentGroup);


                if (this.GroupInfoChanged != null)
                {
                    this.GroupInfoChanged(this.currentGroup);
                }
                this.Close();
            }
            else
            {
                this.toolTip1.Show("提交超时，修改失败！", this.btnRegister, new Point(this.btnRegister.Width / 2, -this.btnRegister.Height), 3000);
            }
        }


    }
}
