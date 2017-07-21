using JustLib.Controls;
namespace GGTalk
{
    partial class GroupFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupFileForm));
            this.btnSendFile = new CCWin.SkinControl.SkinButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSendFile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnSendFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSendFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSendFile.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSendFile.DownBack")));
            this.btnSendFile.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSendFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendFile.Location = new System.Drawing.Point(699, 33);
            this.btnSendFile.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSendFile.MouseBack")));
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSendFile.NormlBack")));
            this.btnSendFile.Size = new System.Drawing.Size(86, 24);
            this.btnSendFile.TabIndex = 147;
            this.btnSendFile.Text = "上传文件";
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 567);
            this.listView1.TabIndex = 150;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // GroupFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BorderPalace = ((System.Drawing.Image)(resources.GetObject("$this.BorderPalace")));
            this.CanResize = true;
            this.ClientSize = new System.Drawing.Size(793, 632);
            this.CloseDownBack = global::GGTalk.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::GGTalk.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::GGTalk.Properties.Resources.btn_close_disable;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSendFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::GGTalk.Properties.Resources.btn_max_down;
            this.MaxMouseBack = global::GGTalk.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::GGTalk.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::GGTalk.Properties.Resources.btn_mini_down;
            this.MinimizeBox = true;
            this.MiniMouseBack = global::GGTalk.Properties.Resources.btn_mini_highlight;
            this.MiniNormlBack = global::GGTalk.Properties.Resources.btn_mini_normal;
            this.Name = "GroupFileForm";
            this.RestoreDownBack = global::GGTalk.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::GGTalk.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::GGTalk.Properties.Resources.btn_restore_normal;
            this.ShowInTaskbar = true;
            this.Text = "群文件";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.NoticeRecordForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnSendFile;
        private System.Windows.Forms.ListView listView1;
    }
}