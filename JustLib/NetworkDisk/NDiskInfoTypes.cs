using System;
using System.Collections.Generic;
using ESPlus.Application.CustomizeInfo;

namespace JustLib.NetworkDisk
{
	/// <summary>
    /// ������������ص���Ϣ���͵Ŀռ䡣Ĭ��ȡֵ -100 ~ 0
	/// </summary>	
    public class NDiskInfoTypes : BaseInformationTypes
	{
        #region Ctor
        public NDiskInfoTypes()
            : this(-100)
        {
        }
        public NDiskInfoTypes(int _startKey)
        {
            base.StartKey = _startKey;
            base.Initialize();
        } 
        #endregion

        #region ReqDirectory 
        private int reqDirectory = 1;
        /// <summary>
        /// ����Ŀ¼��Ϣ������Э��ΪReqDirectoryContract���ظ�ΪResDirectoryContract
        /// </summary>
        public int ReqDirectory
		{
			get
			{
                return this.reqDirectory;
			}
			set
			{
                this.reqDirectory = value;
			}
		}
		#endregion        

        #region CreateDirectory
        private int createDirectory = 2;
        /// <summary>
        /// ����Ŀ¼��
        /// </summary>
        public int CreateDirectory
		{
			get
			{
                return this.createDirectory;
			}
			set
			{
                this.createDirectory = value;
			}
		}
		#endregion

        #region Delete
        private int delete = 3;
        /// <summary>
        /// ɾ���ļ����ļ��С�����Э��DeleteContract���ظ�Э��OperationResultConatract��
        /// </summary>
        public int Delete
		{
			get
			{
                return this.delete;
			}
			set
			{
                this.delete = value;
			}
		}
		#endregion        

        #region Rename
        private int rename = 4;
        /// <summary>
        /// Ϊ�ļ����ļ���������������Э��RenameContract���ظ�Э��OperationResultConatract��
        /// </summary>
        public int Rename
        {
            get { return rename; }
            set { rename = value; }
        } 
        #endregion

        #region ReqNetworkDiskState
        private int reqNetworkDiskState = 5;
        /// <summary>
        /// ��ȡ����Ӳ�̵�״̬������Э��Ϊnull���ظ�Э��ΪResNetworkDiskStateContract��
        /// </summary>
        public int ReqNetworkDiskState
        {
            get { return reqNetworkDiskState; }
            set { reqNetworkDiskState = value; }
        } 
        #endregion        

        #region Move
        private int move = 6;
        /// <summary>
        /// �ƶ�����ļ����ļ��С�����Э��ΪMoveContract���ظ�Э��OperationResultConatract��
        /// </summary>
        public int Move
        {
            get { return move; }
            set { move = value; }
        } 
        #endregion        

        #region Copy
        private int copy = 7;
        /// <summary>
        /// ���ƶ���ļ����ļ��С�����Э��ΪCopyContract���ظ�Э��OperationResultConatract��
        /// </summary>
        public int Copy
        {
            get { return copy; }
            set { copy = value; }
        } 
        #endregion       

        #region Download
        private int download = 8;
        /// <summary>
        /// ���������ļ����У�������Э��ΪDownloadContract���ظ�Э��OperationResultConatract��
        /// </summary>
        public int Download
        {
            get
            {
                return this.download;
            }
            set
            {
                this.download = value;
            }
        }
        #endregion        
	}
}
