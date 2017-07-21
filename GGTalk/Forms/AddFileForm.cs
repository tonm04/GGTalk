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
using JustLib.Records;
using ESPlus.Serialization;
using ESPlus.Application;
using JustLib.Controls;

namespace GGTalk
{
    internal partial class AddFileForm : BaseForm
    {
        private IRapidPassiveEngine rapidPassiveEngine;
        private IGroup ggSupporter;

        public AddFileForm(IRapidPassiveEngine engine, IGroup supporter)
        {
            InitializeComponent();
            this.rapidPassiveEngine = engine;
            this.ggSupporter = supporter;

            this.Text += " - " + supporter.Name;

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



        private int sendingCount = 0;
        private void HandleSentResult(bool succeed, object tag)
        {
            --this.sendingCount;
            if (this.sendingCount <= 0)
            {
                this.sendingCount = 0;
                //this.gifBox_wait.Visible = false;
            }

            if (!succeed)
            {
                // this.toolShow.Show("因为网络原因，刚才的消息尚未发送成功！", this.skinButton_send, new Point(this.skinButton_send.Width / 2, -this.skinButton_send.Height), 3000);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
             

        }

        private void skinTextBox_id_SkinTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
