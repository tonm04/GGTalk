using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ESBasic;
using ESPlus.FileTransceiver;
using ESPlus.Application.FileTransfering.Passive;
using ESBasic.Threading.Engines;

namespace JustLib.Controls
{
    /// <summary>
    /// �ļ����Ͳ鿴�������ڲ鿴��ĳ�����ѵ������ļ����͵Ľ���״̬��Ϣ��
    /// ע�⣬FileTransferingViewer�������¼�������UI�߳��д����ġ�
    /// </summary>
    public partial class FileTransferingViewer : UserControl, IFileTransferingViewer ,IEngineActor
    {
        private ESBasic.Func<TransferingProject, bool> projectFilter;
        private IFileOutter fileOutter;   
        private AgileCycleEngine agileCycleEngine;

        #region event FileTransferingViewer�������¼�������UI�߳��д����ġ�

        /// <summary>
        /// ��ĳ���ļ���ʼ����ʱ���������¼�������ΪFileName - isSending
        /// </summary>
        public event CbGeneric<string, bool> FileResumedTransStarted; 

        /// <summary>
        /// ��ĳ���ļ��������ʱ���������¼�������ΪFileName - isSending - comment - isFolder
        /// </summary>
        public event CbGeneric<string, bool, string ,bool> FileTransCompleted;

        /// <summary>
        /// ��ĳ���ļ������ж�ʱ���������¼�������ΪFileName - isSending - FileTransDisrupttedType
        /// </summary>
        public event CbGeneric<string, bool, FileTransDisrupttedType> FileTransDisruptted;

        /// <summary>
        /// ��ĳ���ļ����Ϳ�ʼʱ���������¼�������ΪFileName - isSending
        /// </summary>
        public event CbGeneric<string, bool> FileTransStarted;

        /// <summary>
        /// �������ļ����������ʱ���������¼���
        /// </summary>
        public event CbSimple AllTaskFinished;       
        #endregion       

        #region Ctor
        public FileTransferingViewer()
        {
            InitializeComponent();

            this.agileCycleEngine = new AgileCycleEngine(this);
            this.agileCycleEngine.DetectSpanInSecs = 1;
            this.agileCycleEngine.Start();

            this.FileResumedTransStarted += delegate { };
            this.FileTransCompleted += delegate { };
            this.FileTransDisruptted += delegate { };
            this.FileTransStarted += delegate { };
            this.AllTaskFinished += delegate { };            
        } 
        #endregion

        #region Initialize
        public void Initialize(IFileOutter _fileOutter)
        {
            this.Initialize(_fileOutter, (Func<TransferingProject, bool>)null);
        }

        public void Initialize(IFileOutter _fileOutter, string friendUserID)
        {
            if (friendUserID == null)
            {
                friendUserID = ESFramework.NetServer.SystemUserID;
            }
            this.Initialize(_fileOutter, delegate(TransferingProject pro) { return pro.DestUserID == friendUserID; });
        }


        /// <summary>
        /// ��ʼ���ؼ���
        /// </summary>         
        /// <param name="filter">��ǰ��ViewerҪ��ʾ��Щ������Ŀ��״̬��Ϣ</param>        
        public void Initialize(IFileOutter _fileOutter, Func<TransferingProject, bool> filter)
        {            
            this.fileOutter = _fileOutter;
            this.projectFilter = filter;            

            //this.fileOutter.FileRequestReceived += new ESPlus.Application.FileTransfering.CbFileRequestReceived(fileOutter_FileRequestReceived);
            this.fileOutter.FileSendingEvents.FileTransStarted += new CbGeneric<TransferingProject>(fileTransStarted);
            this.fileOutter.FileSendingEvents.FileTransCompleted += new CbGeneric<TransferingProject>(fileTransCompleted);
            this.fileOutter.FileSendingEvents.FileTransDisruptted += new CbGeneric<TransferingProject, FileTransDisrupttedType>(fileTransDisruptted);
            this.fileOutter.FileSendingEvents.FileTransProgress += new CbFileSendedProgress(fileTransProgress);
            this.fileOutter.FileSendingEvents.FileResumedTransStarted += new CbGeneric<TransferingProject>(fileSenderManager_FileResumedTransStarted);

            this.fileOutter.FileReceivingEvents.FileTransStarted += new CbGeneric<TransferingProject>(fileTransStarted);
            this.fileOutter.FileReceivingEvents.FileResumedTransStarted += new CbGeneric<TransferingProject>(fileReceiverManager_FileResumedTransStarted);
            this.fileOutter.FileReceivingEvents.FileTransCompleted += new CbGeneric<TransferingProject>(fileTransCompleted);
            this.fileOutter.FileReceivingEvents.FileTransDisruptted += new CbGeneric<TransferingProject, FileTransDisrupttedType>(fileTransDisruptted);
            this.fileOutter.FileReceivingEvents.FileTransProgress += new CbFileSendedProgress(fileTransProgress);            
        }

        public List<string> GetTransferingProjectIDsInCurrentViewer()
        {
            List<string> list = new List<string>();
            foreach (FileTransferItem item in this.flowLayoutPanel1.Controls)
            {
               list.Add(item.TransmittingProject.ProjectID) ;                
            }

            return list; 
        }

        /// <summary>
        /// ���յ������ļ�������ʱ,���շ����ô˷�����ʾfileTransferItem
        /// </summary>        
        public void NewFileTransferItem(string projectID, bool offlineFile, bool doneAgreed)
        {
            TransferingProject pro = this.fileOutter.GetTransferingProject(projectID);
            if (pro == null)
            {
                return;
            }

            if (this.projectFilter != null)
            {
                if (!this.projectFilter(pro))
                {
                    return;
                }
            }

            this.AddFileTransItem(pro, offlineFile, doneAgreed);
        }

        /// <summary>
        ///  һ��Ҫ�ڿؼ����ٵ�ʱ��ȡ��Ԥ�����¼��������ѱ��ͷŵĿؼ��Ĵ�������Ȼ�ᱻ���ã�������"�����Ѿ����ͷ�"���쳣��
        /// </summary>        
        public void BeforeDispose()
        {
            this.agileCycleEngine.StopAsyn();

            this.fileOutter.FileSendingEvents.FileTransStarted -= new CbGeneric<TransferingProject>(fileTransStarted);
            this.fileOutter.FileSendingEvents.FileTransCompleted -= new CbGeneric<TransferingProject>(fileTransCompleted);
            this.fileOutter.FileSendingEvents.FileTransDisruptted -= new CbGeneric<TransferingProject, FileTransDisrupttedType>(fileTransDisruptted);
            this.fileOutter.FileSendingEvents.FileTransProgress -= new CbFileSendedProgress(fileTransProgress);
            this.fileOutter.FileSendingEvents.FileResumedTransStarted -= new CbGeneric<TransferingProject>(fileSenderManager_FileResumedTransStarted);
            
            this.fileOutter.FileReceivingEvents.FileTransStarted -= new CbGeneric<TransferingProject>(fileTransStarted);
            this.fileOutter.FileReceivingEvents.FileResumedTransStarted -= new CbGeneric<TransferingProject>(fileReceiverManager_FileResumedTransStarted);
            this.fileOutter.FileReceivingEvents.FileTransCompleted -= new CbGeneric<TransferingProject>(fileTransCompleted);
            this.fileOutter.FileReceivingEvents.FileTransDisruptted -= new CbGeneric<TransferingProject, FileTransDisrupttedType>(fileTransDisruptted);
            this.fileOutter.FileReceivingEvents.FileTransProgress -= new CbFileSendedProgress(fileTransProgress);
        }   

        void fileReceiverManager_FileResumedTransStarted(TransferingProject info)
        {
            if (this.projectFilter != null)
            {
                if (!this.projectFilter(info))
                {
                    return;
                }
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new CbGeneric<TransferingProject>(this.fileReceiverManager_FileResumedTransStarted), info);
            }
            else
            {             
                FileTransferItem item = this.GetExistedItem(info.ProjectID);
                if (item != null)
                {
                    this.FileResumedTransStarted(info.ProjectName, false);
                }
            }
        }

        void fileSenderManager_FileResumedTransStarted(TransferingProject info)
        {
            if (this.projectFilter != null)
            {
                if (!this.projectFilter(info))
                {
                    return;
                }
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new CbGeneric<TransferingProject>(this.fileSenderManager_FileResumedTransStarted), info);
            }
            else
            {
                this.AddFileTransItem(info ,false, true);
                FileTransferItem item = this.GetExistedItem(info.ProjectID);
                if (item != null)
                {
                    this.FileResumedTransStarted(info.ProjectName ,true);
                }
            }
        }

        /// <summary>
        /// ��ǰ�Ƿ����ļ����ڴ����С�
        /// </summary>   
        public bool IsFileTransfering
        {
            get
            {
                return (this.flowLayoutPanel1.Controls.Count > 0);
            }
        }
        #endregion    
               
        #region fileTransStarted
        void fileTransStarted(TransferingProject info)
        {
            //if (!this.IsHandleCreated)
            //{
            //    return;
            //}

            if (this.projectFilter != null)
            {
                if (!this.projectFilter(info))
                {
                    return;
                }
            }

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<TransferingProject>(this.fileTransStarted), info);
            }
            else
            {
                this.AddFileTransItem(info ,false ,true);
                FileTransferItem item = this.GetExistedItem(info.ProjectID);
                if (item != null)
                {
                    item.IsTransfering = true;
                }
            }
        } 
        #endregion

        #region fileTransProgress
        void fileTransProgress(string projectID, ulong total, ulong sended)
        {
            //if (!this.IsHandleCreated)
            //{
            //    return;
            //}

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric<string, ulong, ulong>(this.fileTransProgress), projectID, total, sended);
            }
            else
            {
                FileTransferItem item = this.GetExistedItem(projectID);
                if (item != null)
                {
                    item.SetProgress(total, sended);
                }
            }
        } 
        #endregion

        #region fileTransDisruptted
        void fileTransDisruptted(TransferingProject info, FileTransDisrupttedType disrupttedType)
        {
            //if (!this.IsHandleCreated)
            //{
            //    return;
            //}

            if (this.InvokeRequired)
            {
                this.Invoke(new CbGeneric<TransferingProject, FileTransDisrupttedType>(this.fileTransDisruptted), info, disrupttedType);
            }
            else
            {               
                FileTransferItem item = this.GetExistedItem(info.ProjectID);
                if (item != null)
                {
                    this.flowLayoutPanel1.Controls.Remove(item);
                    this.FileTransDisruptted(info.ProjectName, info.IsSender, disrupttedType);
                }
            }
        } 
        #endregion

        #region fileTransCompleted
        void fileTransCompleted(TransferingProject info)
        {
            //if (!this.IsHandleCreated)
            //{
            //    return;
            //}

            if (this.InvokeRequired)
            {
                this.Invoke(new CbGeneric<TransferingProject>(this.fileTransCompleted), info);
            }
            else
            {              
                FileTransferItem item = this.GetExistedItem(info.ProjectID);
                if (item != null)
                {
                    this.flowLayoutPanel1.Controls.Remove(item);
                    this.FileTransCompleted(info.ProjectName, info.IsSender, info.Comment ,info.IsFolder);
                }
            }
        } 
        #endregion          

       
        #region AddFileTransItem ,GetFileTransItem        
        private void AddFileTransItem(TransferingProject project, bool offlineFile, bool doneAgreed)
        {
            if (this.projectFilter != null)
            {
                if (!this.projectFilter(project))
                {
                    return;
                }
            }

            FileTransferItem fileTransItem = this.GetExistedItem(project.ProjectID);
            if (fileTransItem != null)
            {
                return;
            }
            fileTransItem = new FileTransferItem();
            fileTransItem.FileCanceled += new CbFileCanceled(fileTransItem_FileCanceled);
            fileTransItem.FileReceived += new CbFileReceived(fileTransItem_FileReceived);
            fileTransItem.FileRejected += new CbFileRejected(fileTransItem_FileRejected);
            fileTransItem.Initialize(project, offlineFile ,doneAgreed);
            this.flowLayoutPanel1.Controls.Add(fileTransItem);
            this.FileTransStarted(project.ProjectName, project.IsSender);
        }

        private FileTransferItem GetExistedItem(string projectID)
        {
            foreach (FileTransferItem item in this.flowLayoutPanel1.Controls)
            {
                if (item.TransmittingProject.ProjectID == projectID)
                {
                    return item;
                }
            }      

            return null; 
        }        

        void fileTransItem_FileRejected(string projectID)
        {
            this.fileOutter.RejectFile(projectID);            
        }

        void fileTransItem_FileReceived(FileTransferItem item, string projectID, bool isSend, string savePath)
        {
            this.fileOutter.BeginReceiveFile(projectID, savePath);
        }        

        void fileTransItem_FileCanceled(FileTransferItem item, string projectID, bool isSend)
        {
            this.fileOutter.CancelTransfering(projectID);             
        }
        #endregion      

        #region flowLayoutPanel1_ControlRemoved
        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count == 0)
            {
                this.AllTaskFinished();
            }
        } 
        #endregion

        #region EngineAction
        public bool EngineAction()
        {
            try
            {
                this.CheckZeroSpeed();
            }
            catch { }
            return true;
        }

        private void CheckZeroSpeed()
        {
            //if (!this.IsHandleCreated)
            //{
            //    return;
            //}

            if (this.InvokeRequired)
            {
                this.Invoke(new CbGeneric(this.CheckZeroSpeed));
            }
            else
            {
                foreach (object obj in this.flowLayoutPanel1.Controls)
                {
                    FileTransferItem item = obj as FileTransferItem;
                    if (item != null && item.IsTransfering)
                    {
                        item.CheckZeroSpeed();
                    }
                }
            }
        }
        #endregion
    }

    internal delegate FileTransferItem CbGetFileTransItem(string projectID, bool isSended);
    internal delegate FileTransferItem CbGetFileTransItem2(string projectID);
    public delegate void CbFileReceiveCanceled(string friend ,string projectID) ;
    public delegate void CbCancelFile(string projectID,bool isSsend);
}
