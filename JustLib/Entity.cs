using System;
using System.Collections.Generic;
using System.Text;
using ESBasic;
using System.Drawing;

namespace JustLib
{
    #region IUnit
    public interface IUnit
    {
        string ID { get; }
        string Name { get; }
        int Version { get; set; }
        string LastWords { get; }

        bool IsGroup { get; }

        object Tag { get; set; }
        Parameter<string, string> GetIDName();
    } 
    #endregion

    #region IUser
    public interface IUser : IUnit
    {
        List<string> GroupList { get; }
        UserStatus UserStatus { get; set; }
        object Tag { get; set; }
        Dictionary<string, List<string>> FriendDicationary { get; }
        string Signature { get; }
        string DefaultFriendCatalog { get; }

        /// <summary>
        /// 如果为空字符串，则表示位于组织外。
        /// </summary>
        string Department { get; }
        string[] OrgPath { get; }
        bool IsInOrg { get; } 

        List<string> GetAllFriendList();
        List<string> GetFriendCatalogList();       
    }
    #endregion

    #region IGroup
    public interface IGroup : IUnit
    {
        string CreatorID { get; }
        string Name { get; set; }
        string Announce { get; set; }

        List<string> MemberList { get; }

        List<string> NoSpeakList { get; }
        List<string> ManagerList { get; }

        void AddMember(string userID);
        void RemoveMember(string userID);
        void AddNoSpeak(string userID);
        void RemoveNoSpeak(string userID);

        

    }
    #endregion



    #region IGroupFile
    public interface IGroupFile  
    {
        // <summary>
        /// 条目的唯一编号，数据库自增序列，主键。
        /// </summary>
          string SID { get; set; }

        /// <summary>
        /// 离线文件的名称。
        /// </summary>
          string FileName { get; set; }

        /// <summary>
        /// 文件的大小。
        /// </summary>
          long FileLength { get; set; }

        /// <summary>
        /// 发送者ID。
        /// </summary>
          string SenderID { get; set; }

        /// <summary>
        /// 发送日期。
        /// </summary>
          string SendDate { get; set; }

        /// <summary>
        /// 群组ID。
        /// </summary>
          string GroupID { get; set; }

        /// <summary>
        /// 在服务器上存储离线文件的临时路径。
        /// </summary>
          string RelayFilePath { get; set; }



    }
    #endregion






    public interface IHeadImageGetter
    {
        Image GetHeadImage(IUser user);
    }

    public interface IUserInformationForm
    {
        void SetUser(IUser user);
    }

    //在线状态
    public enum UserStatus
    {
        Online = 2,
        Away = 3,
        Busy = 4,
        DontDisturb = 5,
        OffLine = 6,
        Hide = 7
    }

    public enum GroupChangedType
    {
        /// <summary>
        /// 成员的资料发生变化
        /// </summary>
        MemberInfoChanged = 0,
        /// <summary>
        /// 组的资料（如组名称、公告等）发生变化
        /// </summary>
        GroupInfoChanged,
        SomeoneJoin,
        SomeoneQuit,
        GroupDeleted,
        SomeoneNoSpeak,
        SomeoneAllowSpeak,
        SomeoneRemove,
        SomeoneAdd,
        SomeoneAddManagers,
        SomeoneRemoveManagers,
        BroadcastNotice

    }

    #region ContactRTDatas
    public class UserRTData
    {
        public UserRTData() { }
        public UserRTData(UserStatus status, int ver)
        {
            this.UserStatus = status;
            this.Version = ver;
        }

        public UserStatus UserStatus { get; set; }
        public int Version { get; set; }
    }

    public class ContactRTDatas
    {
        public Dictionary<string, UserRTData> UserStatusDictionary { get; set; }
        public Dictionary<string, int> GroupVersionDictionary { get; set; }
    } 
    #endregion
}
