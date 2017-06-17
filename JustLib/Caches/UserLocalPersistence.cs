using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JustLib.Caches
{
    /// <summary>
    /// 在客户端本地持久化保存用户资料、群资料、最近联系人列表。
    /// </summary>  
    [Serializable]
    public class UserLocalPersistence<TUser, TGroup>
    {
        #region Load、Save
        public static UserLocalPersistence<TUser, TGroup> Load(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return null;
                }

                byte[] data = ESBasic.Helpers.FileHelper.ReadFileReturnBytes(filePath);
                return (UserLocalPersistence<TUser, TGroup>)ESBasic.Helpers.SerializeHelper.DeserializeBytes(data, 0, data.Length);
            }
            catch
            {
                return null;
            }
        }

        public void Save(string filePath)
        {
            byte[] data = ESBasic.Helpers.SerializeHelper.SerializeObject(this);
            ESBasic.Helpers.FileHelper.WriteBuffToFile(data, filePath);
        } 
        #endregion

        public UserLocalPersistence() { }
        public UserLocalPersistence(List<TUser> friends, List<TGroup> groups, List<string> list)
        {
            this.friendList = friends;
            this.groupList = groups ?? new List<TGroup>();
            this.recentList = list ?? new List<string>();
        }             

        #region FriendList
        private List<TUser> friendList = new List<TUser>();
        /// <summary>
        /// 好友缓存。（包括组友）
        /// </summary>
        public List<TUser> FriendList
        {
            get { return friendList; }
            set { friendList = value; }
        }
        #endregion

        #region GroupList
        private List<TGroup> groupList = new List<TGroup>();
        public List<TGroup> GroupList
        {
            get { return groupList; }
            set { groupList = value; }
        } 
        #endregion

        #region RecentList
        private List<string> recentList = new List<string>();
        /// <summary>
        /// 最近联系人
        /// </summary>
        public List<string> RecentList
        {
            get { return recentList; }
            set { recentList = value; }
        }
        #endregion
    }    
}
