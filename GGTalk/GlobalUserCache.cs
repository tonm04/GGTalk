using System;
using System.Collections.Generic;
using System.Text;
using ESBasic.ObjectManagement.Managers;
using ESPlus.Rapid;
using ESPlus.Serialization;
using ESBasic;
using System.IO;
using System.Threading;
using JustLib.Caches;
using JustLib;

namespace GGTalk
{
    public class GlobalUserCache : BaseGlobalUserCache<GGUser, GGGroup>, IUserNameGetter
    {
        private IRapidPassiveEngine rapidPassiveEngine;

        public GlobalUserCache(IRapidPassiveEngine engine)
        {
            this.rapidPassiveEngine = engine;
            string persistenceFilePath = SystemSettings.SystemSettingsDir + engine.CurrentUserID + ".dat";
            this.Initialize(this.rapidPassiveEngine.CurrentUserID, persistenceFilePath, GlobalConsts.CompanyGroupID, GlobalResourceManager.Logger);
        }

        public override void Initialize(string curUserID, string persistencePath, string _companyGroupID, ESBasic.Loggers.IAgileLogger _logger)
        {
            base.Initialize(curUserID, persistencePath, _companyGroupID, _logger);
        }

        protected override GGUser DoGetUser(string userID)
        {
            byte[] bUser = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.GetUserInfo, System.Text.Encoding.UTF8.GetBytes(userID));
            if (bUser == null)
            {
                return null;
            }
            return ESPlus.Serialization.CompactPropertySerializer.Default.Deserialize<GGUser>(bUser, 0);
        }

        protected override GGGroup DoGetGroup(string groupID)
        {
            byte[] bGroup = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.GetGroup, System.Text.Encoding.UTF8.GetBytes(groupID));
            return CompactPropertySerializer.Default.Deserialize<GGGroup>(bGroup, 0);
        }
        protected override List<GGGroup> DoGetMyGroups()
        {
            byte[] bMyGroups = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.GetMyGroups, null);
            return CompactPropertySerializer.Default.Deserialize<List<GGGroup>>(bMyGroups, 0);
        }
        protected override List<GGGroup> DoGetSomeGroups(List<string> groupIDList)
        {
            byte[] bMyGroups = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.GetSomeGroups, CompactPropertySerializer.Default.Serialize(groupIDList));
            return CompactPropertySerializer.Default.Deserialize<List<GGGroup>>(bMyGroups, 0);
        }
        protected override ContactRTDatas DoGetContactsRTDatas()
        {
            byte[] res = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.GetContactsRTData, null);
            return ESPlus.Serialization.CompactPropertySerializer.Default.Deserialize<ContactsRTDataContract>(res, 0);
        }
        protected override List<GGUser> DoGetSomeUsers(List<string> userIDList)
        {
            byte[] bFriends = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.GetSomeUsers, CompactPropertySerializer.Default.Serialize(userIDList));
            return CompactPropertySerializer.Default.Deserialize<List<GGUser>>(bFriends, 0);
        }

        protected override List<GGUser> DoGetAllContacts() //好友，包括组友 
        {
            byte[] bFriends = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.GetAllContacts, null);
            return CompactPropertySerializer.Default.Deserialize<List<GGUser>>(bFriends, 0);
        }

        public IUnit GetUnit(string id ,bool isGroup)
        {            
            if (isGroup)
            {
                return this.GetGroup(id);
            }

            return this.GetUser(id);
        }       
    }    
}
