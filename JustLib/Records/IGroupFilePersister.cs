using System;
using System.Collections.Generic;
using System.Text;

namespace JustLib.Records
{
    #region IGroupFilePersister
    /// <summary>
    /// 
    /// </summary>
    public interface IGroupFilePersister
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
         List<GroupFile> GetAllGroupFile(string groupID);
    }
    #endregion
    /// <summary>
    /// 群组文件条目
    /// </summary>
    /// 
    [Serializable]
    public class GroupFile : IGroupFile
    {
        /// <summary>
        /// 条目的唯一编号，数据库自增序列，主键。
        /// </summary>
        public string SID { get; set; }

        /// <summary>
        /// 离线文件的名称。
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件的大小。
        /// </summary>
        public long FileLength { get; set; }

        /// <summary>
        /// 发送者ID。
        /// </summary>
        public string SenderID { get; set; }

        /// <summary>
        /// 发送者ID。
        /// </summary>
        public string SenderName{ get; set; }

        /// <summary>
        /// 发送日期。
        /// </summary>
        public string SendDate { get; set; }

        /// <summary>
        /// 群组ID。
        /// </summary>
        public string GroupID { get; set; }

        /// <summary>
        /// 在服务器上存储离线文件的临时路径。
        /// </summary>
        public string RelayFilePath { get; set; }
    }

}
