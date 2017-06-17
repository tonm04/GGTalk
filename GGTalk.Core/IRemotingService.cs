using System;
using System.Collections.Generic;
using System.Text;
using ESBasic;
using JustLib.Records;

namespace GGTalk
{
    /// <summary>
    /// 用于提供注册服务的Remoting接口。
    /// </summary>
    public interface IRemotingService :IChatRecordPersister
    {
        RegisterResult Register(GGUser user); 

        /// <summary>
        /// 根据ID或Name搜索用户【完全匹配】。
        /// </summary>   
        List<GGUser> SearchUser(string idOrName);

        /// <summary>
        /// 发送系统通知给所有在线用户。
        /// </summary>      
        void SendSystemNotify(string title, string content);
    }

    public enum RegisterResult
    {
        /// <summary>
        /// 成功
        /// </summary>
        Succeed = 0 ,

        /// <summary>
        /// 帐号已经存在
        /// </summary>
        Existed,

        /// <summary>
        /// 过程中出现错误
        /// </summary>
        Error
    }
}
