using System;
using System.Collections.Generic;
using System.Text;


namespace GGTalk.Server
{
    internal class ContactsManager : ESPlus.Application.Contacts.Server.IContactsManager
    {
        private GlobalCache globalCache;
        public ContactsManager(GlobalCache db)
        {
            this.globalCache = db;
        }

        public List<string> GetGroupMemberList(string groupID)
        {
            GGGroup group =  this.globalCache.GetGroup(groupID);
            if (group == null)
            {
                return new List<string>();
            }

            return group.MemberList;
        }       

        public List<string> GetContacts(string userID)
        {
            return this.globalCache.GetAllContacts(userID);
        }
    }
}
