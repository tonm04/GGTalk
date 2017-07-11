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
    internal partial class NoticeForm : BaseForm
    {
        private IRapidPassiveEngine rapidPassiveEngine;
        private IGroup ggSupporter;

        public NoticeForm(IRapidPassiveEngine engine, IGroup supporter)
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

        

        private void skinTextBox_id_SkinTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            AddNoticeForm form = new AddNoticeForm(this.rapidPassiveEngine, this.ggSupporter);
            form.ShowDialog();
        }
    }
}
