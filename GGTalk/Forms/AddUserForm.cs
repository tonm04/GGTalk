using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.Win32;
using CCWin.Win32.Const;
using System.Diagnostics;

using System.Configuration;
using ESPlus.Rapid;
using JustLib;

namespace GGTalk
{
    internal partial class AddUserForm : BaseForm
    {
        private IRapidPassiveEngine rapidPassiveEngine;
        private IGroup ggSupporter;

        public AddUserForm(IRapidPassiveEngine engine, IGroup supporter)
        {
            InitializeComponent();
            this.rapidPassiveEngine = engine;
            this.ggSupporter = supporter;

            int registerPort = int.Parse(ConfigurationManager.AppSettings["RemotingPort"]);
        }

        #region UserID
        private string userID = null;
        public string UserID
        {
            get
            {
                return this.userID;
            }
        }
        #endregion

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.userID = this.skinTextBox_id.SkinTxt.Text.Trim();
            if (userID.Length == 0)
            {
                MessageBoxEx.Show("成员帐号不能为空！");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            //try
            //{
            if (this.ggSupporter.MemberList.Contains(this.userID))
            {
                MessageBoxEx.Show("已经是该群的成员了！");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            byte[] bRes = this.rapidPassiveEngine.CustomizeOutter.Query(InformationTypes.AddMember, System.Text.Encoding.UTF8.GetBytes(ggSupporter .ID+ "|"+userID));
            AddMemberResult res = (AddMemberResult)BitConverter.ToInt32(bRes, 0);
            if (res == AddMemberResult.MemberNotExist)
            {
                MessageBoxEx.Show("成员不存在！");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //}
            //catch (Exception ee)
            //{
            //    MessageBoxEx.Show("加入群失败！" + ee.Message);
            //    this.DialogResult = System.Windows.Forms.DialogResult.None;
            //}
        }

        private void skinTextBox_id_SkinTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
