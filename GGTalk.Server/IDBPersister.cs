using System;
using System.Collections.Generic;
using System.Text;
using JustLib.Records;

namespace GGTalk.Server
{
    public interface IDBPersister : IChatRecordPersister
    {
        void InsertUser(GGUser t);
        void UpdateUserFriends(GGUser t);
        void InsertGroup(GGGroup t);
        void InsertGroupFile(GroupFile t);
        void UpdateUser(GGUser t);
        void UpdateGroup(GGGroup t);
        void DeleteGroup(string groupID);
        void DeleteGroupFile(string SID);
        List<GGUser> GetAllUser();
        List<GGGroup> GetAllGroup();
      //  List<GroupFile> GetAllGroupFile();

        void ChangeUserPassword(string userID, string newPasswordMD5);
        void ChangeUserGroups(string userID, string groups);        
    }    
}
