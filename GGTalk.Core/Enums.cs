using System;
using System.Collections.Generic;
using System.Text;

namespace GGTalk
{
    public enum AddFriendResult
    {
        Succeed = 0,
        FriendNotExist,        
    }

    public enum JoinGroupResult
    {
        Succeed = 0,
        GroupNotExist,   
    }

    public enum  AddMemberResult
    {
        Succeed = 0,
        MemberNotExist,
    }



    public enum AddManagerResult
    {
        Succeed = 0,
        MemberNotExist,
    }


    public enum CreateGroupResult
    {
        Succeed = 0,
        GroupExisted,
    }


    public enum SendGroupFileResult
    {
        Succeed = 0,
        GroupFileExisted,
    }


    public enum DeleteGroupFileResult
    {
        Succeed = 0,
        GroupFileExisted,
    }



    public enum ChangePasswordResult
    {
        Succeed = 0,
        OldPasswordWrong,
        UserNotExist
    }
}
