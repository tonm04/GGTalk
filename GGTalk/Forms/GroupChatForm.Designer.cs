using JustLib.Controls;
namespace GGTalk
{
    partial class GroupChatForm
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
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.ChatListItem chatListItem1 = new CCWin.SkinControl.ChatListItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupChatForm));
            this.chatListBox1 = new CCWin.SkinControl.ChatListBox();
            this.toolShow = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.skinButton_send = new CCWin.SkinControl.SkinButton();
            this.btnClose = new CCWin.SkinControl.SkinButton();
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.视频聊天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语音视频设备测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.语音聊天ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.语音视频设备测试ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolFile = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.发送离线文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.请求远程协助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桌面共享指定区域ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_adduser = new System.Windows.Forms.ToolStripButton();
            this.linkLabel_softName = new System.Windows.Forms.LinkLabel();
            this.pnlTx = new CCWin.SkinControl.SkinPanel();
            this.panelFriendHeadImage = new CCWin.SkinControl.SkinPanel();
            this.labelGroupName = new CCWin.SkinControl.SkinLabel();
            this.skToolMenu = new CCWin.SkinControl.SkinToolStrip();
            this.toolFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEmotion = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.label_announce = new CCWin.SkinControl.SkinLabel();
            this.gifBox_wait = new JustLib.Controls.GifBox();
            this.chatBoxSend = new JustLib.Controls.ChatBox();
            this.chatBox_history = new JustLib.Controls.ChatBox();
            this.skinToolStrip2.SuspendLayout();
            this.pnlTx.SuspendLayout();
            this.skToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatListBox1
            // 
            this.chatListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chatListBox1.DrawContentType = CCWin.SkinControl.DrawContentType.None;
            this.chatListBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chatListBox1.ForeColor = System.Drawing.Color.Black;
            this.chatListBox1.FriendsMobile = true;
            this.chatListBox1.IconSizeMode = CCWin.SkinControl.ChatListItemIcon.Small;
            chatListItem1.Bounds = new System.Drawing.Rectangle(0, 1, 200, 25);
            chatListItem1.IsOpen = true;
            chatListItem1.IsTwinkleHide = false;
            chatListItem1.OwnerChatListBox = this.chatListBox1;
            chatListItem1.Text = "群成员";
            chatListItem1.TwinkleSubItemNumber = 0;
            this.chatListBox1.Items.AddRange(new CCWin.SkinControl.ChatListItem[] {
            chatListItem1});
            this.chatListBox1.ListHadOpenGroup = null;
            this.chatListBox1.ListSubItemMenu = null;
            this.chatListBox1.Location = new System.Drawing.Point(466, 89);
            this.chatListBox1.Name = "chatListBox1";
            this.chatListBox1.SelectSubItem = null;
            this.chatListBox1.ShowNicName = true;
            this.chatListBox1.Size = new System.Drawing.Size(200, 472);
            this.chatListBox1.SubItemMenu = null;
            this.chatListBox1.TabIndex = 0;
            this.chatListBox1.Text = "chatListBox1";
            this.chatListBox1.DoubleClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListEventHandler(this.chatListBox1_DoubleClickSubItem);
            this.chatListBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chatListBox1_MouseClick);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel2.Image = global::GGTalk.Properties.Resources.pictureBox1_Image;
            this.toolStripLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 24);
            this.toolStripLabel2.Text = "toolStripButton6";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            this.fontDialog1.ShowColor = true;
            // 
            // skinButton_send
            // 
            this.skinButton_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton_send.BackColor = System.Drawing.Color.Transparent;
            this.skinButton_send.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.skinButton_send.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton_send.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.skinButton_send.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton_send.DownBack")));
            this.skinButton_send.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton_send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton_send.Location = new System.Drawing.Point(380, 533);
            this.skinButton_send.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton_send.MouseBack")));
            this.skinButton_send.Name = "skinButton_send";
            this.skinButton_send.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton_send.NormlBack")));
            this.skinButton_send.Size = new System.Drawing.Size(69, 24);
            this.skinButton_send.TabIndex = 127;
            this.skinButton_send.Text = "发送(&S)";
            this.skinButton_send.UseVisualStyleBackColor = false;
            this.skinButton_send.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.btnClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DownBack = ((System.Drawing.Image)(resources.GetObject("btnClose.DownBack")));
            this.btnClose.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(305, 533);
            this.btnClose.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnClose.MouseBack")));
            this.btnClose.Name = "btnClose";
            this.btnClose.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnClose.NormlBack")));
            this.btnClose.Size = new System.Drawing.Size(69, 24);
            this.btnClose.TabIndex = 127;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinToolStrip2.Arrow = System.Drawing.Color.White;
            this.skinToolStrip2.AutoSize = false;
            this.skinToolStrip2.Back = System.Drawing.Color.White;
            this.skinToolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip2.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.BaseItemAnamorphosis = true;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.skinToolStrip2.BaseItemBorderShow = true;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skinToolStrip2.BaseItemRadius = 2;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.skinToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.Black;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ItemAnamorphosis = false;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = false;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 1;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton3,
            this.ToolFile,
            this.toolStripButton4,
            this.toolStripSplitButton2,
            this.btn_adduser});
            this.skinToolStrip2.Location = new System.Drawing.Point(1, 53);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Size = new System.Drawing.Size(665, 33);
            this.skinToolStrip2.SkinAllColor = true;
            this.skinToolStrip2.TabIndex = 142;
            this.skinToolStrip2.Text = "skinToolStrip2";
            this.skinToolStrip2.TitleAnamorphosis = false;
            this.skinToolStrip2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.视频聊天ToolStripMenuItem,
            this.语音视频设备测试ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 30);
            this.toolStripSplitButton1.Text = "视频聊天";
            // 
            // 视频聊天ToolStripMenuItem
            // 
            this.视频聊天ToolStripMenuItem.Name = "视频聊天ToolStripMenuItem";
            this.视频聊天ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.视频聊天ToolStripMenuItem.Text = "视频聊天";
            // 
            // 语音视频设备测试ToolStripMenuItem
            // 
            this.语音视频设备测试ToolStripMenuItem.Name = "语音视频设备测试ToolStripMenuItem";
            this.语音视频设备测试ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.语音视频设备测试ToolStripMenuItem.Text = "语音视频设备测试";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.语音聊天ToolStripMenuItem,
            this.语音视频设备测试ToolStripMenuItem1});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 30);
            this.toolStripSplitButton3.Text = "语音聊天";
            // 
            // 语音聊天ToolStripMenuItem
            // 
            this.语音聊天ToolStripMenuItem.Name = "语音聊天ToolStripMenuItem";
            this.语音聊天ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.语音聊天ToolStripMenuItem.Text = "语音聊天";
            // 
            // 语音视频设备测试ToolStripMenuItem1
            // 
            this.语音视频设备测试ToolStripMenuItem1.Name = "语音视频设备测试ToolStripMenuItem1";
            this.语音视频设备测试ToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.语音视频设备测试ToolStripMenuItem1.Text = "语音视频设备测试";
            // 
            // ToolFile
            // 
            this.ToolFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem32,
            this.toolStripMenuItem33,
            this.toolStripMenuItem34,
            this.发送离线文件夹ToolStripMenuItem});
            this.ToolFile.Image = ((System.Drawing.Image)(resources.GetObject("ToolFile.Image")));
            this.ToolFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolFile.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.ToolFile.Name = "ToolFile";
            this.ToolFile.Size = new System.Drawing.Size(36, 30);
            this.ToolFile.Text = "toolStripButton8";
            this.ToolFile.ToolTipText = "发送文件";
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem32.Text = "发送文件";
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem33.Text = "发送文件夹";
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem34.Text = "发送离线文件";
            // 
            // 发送离线文件夹ToolStripMenuItem
            // 
            this.发送离线文件夹ToolStripMenuItem.Name = "发送离线文件夹ToolStripMenuItem";
            this.发送离线文件夹ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.发送离线文件夹ToolStripMenuItem.Text = "发送离线文件夹";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::GGTalk.Properties.Resources.Boot1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 31);
            this.toolStripButton4.Text = "远程磁盘";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.请求远程协助ToolStripMenuItem,
            this.桌面共享指定区域ToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(36, 30);
            // 
            // 请求远程协助ToolStripMenuItem
            // 
            this.请求远程协助ToolStripMenuItem.Name = "请求远程协助ToolStripMenuItem";
            this.请求远程协助ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.请求远程协助ToolStripMenuItem.Text = "请求远程协助";
            // 
            // 桌面共享指定区域ToolStripMenuItem
            // 
            this.桌面共享指定区域ToolStripMenuItem.Name = "桌面共享指定区域ToolStripMenuItem";
            this.桌面共享指定区域ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.桌面共享指定区域ToolStripMenuItem.Text = "请求远程协助（指定桌面区域）";
            // 
            // btn_adduser
            // 
            this.btn_adduser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_adduser.Image = global::GGTalk.Properties.Resources.Add_User;
            this.btn_adduser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(23, 30);
            this.btn_adduser.Text = "添加群成员";
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // linkLabel_softName
            // 
            this.linkLabel_softName.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel_softName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_softName.AutoSize = true;
            this.linkLabel_softName.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_softName.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel_softName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_softName.ForeColor = System.Drawing.Color.Black;
            this.linkLabel_softName.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_softName.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_softName.Location = new System.Drawing.Point(5, 537);
            this.linkLabel_softName.Name = "linkLabel_softName";
            this.linkLabel_softName.Size = new System.Drawing.Size(50, 17);
            this.linkLabel_softName.TabIndex = 130;
            this.linkLabel_softName.TabStop = true;
            this.linkLabel_softName.Text = "GGTalk";
            this.linkLabel_softName.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            // 
            // pnlTx
            // 
            this.pnlTx.BackColor = System.Drawing.Color.Transparent;
            this.pnlTx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTx.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.pnlTx.Controls.Add(this.panelFriendHeadImage);
            this.pnlTx.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTx.DownBack = global::GGTalk.Properties.Resources.aio_head_normal;
            this.pnlTx.Location = new System.Drawing.Point(6, 7);
            this.pnlTx.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTx.MouseBack = global::GGTalk.Properties.Resources.aio_head_normal;
            this.pnlTx.Name = "pnlTx";
            this.pnlTx.NormlBack = global::GGTalk.Properties.Resources.aio_head_normal;
            this.pnlTx.Palace = true;
            this.pnlTx.Size = new System.Drawing.Size(46, 46);
            this.pnlTx.TabIndex = 104;
            // 
            // panelFriendHeadImage
            // 
            this.panelFriendHeadImage.BackColor = System.Drawing.Color.Transparent;
            this.panelFriendHeadImage.BackgroundImage = global::GGTalk.Properties.Resources.Group2;
            this.panelFriendHeadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFriendHeadImage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panelFriendHeadImage.DownBack = null;
            this.panelFriendHeadImage.Location = new System.Drawing.Point(3, 3);
            this.panelFriendHeadImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelFriendHeadImage.MouseBack = null;
            this.panelFriendHeadImage.Name = "panelFriendHeadImage";
            this.panelFriendHeadImage.NormlBack = null;
            this.panelFriendHeadImage.Radius = 5;
            this.panelFriendHeadImage.Size = new System.Drawing.Size(40, 40);
            this.panelFriendHeadImage.TabIndex = 6;
            // 
            // labelGroupName
            // 
            this.labelGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGroupName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.BackColor = System.Drawing.Color.Transparent;
            this.labelGroupName.BorderColor = System.Drawing.Color.White;
            this.labelGroupName.BorderSize = 4;
            this.labelGroupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelGroupName.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.labelGroupName.ForeColor = System.Drawing.Color.Black;
            this.labelGroupName.Location = new System.Drawing.Point(55, 7);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(80, 25);
            this.labelGroupName.TabIndex = 100;
            this.labelGroupName.Text = "测试群1";
            this.labelGroupName.MouseEnter += new System.EventHandler(this.labelFriendName_MouseEnter);
            this.labelGroupName.MouseLeave += new System.EventHandler(this.labelFriendName_MouseLeave);
            // 
            // skToolMenu
            // 
            this.skToolMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skToolMenu.Arrow = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skToolMenu.AutoSize = false;
            this.skToolMenu.Back = System.Drawing.Color.White;
            this.skToolMenu.BackColor = System.Drawing.Color.Transparent;
            this.skToolMenu.BackRadius = 4;
            this.skToolMenu.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skToolMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skToolMenu.BaseFore = System.Drawing.Color.Black;
            this.skToolMenu.BaseForeAnamorphosis = false;
            this.skToolMenu.BaseForeAnamorphosisBorder = 4;
            this.skToolMenu.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skToolMenu.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skToolMenu.BaseHoverFore = System.Drawing.Color.Black;
            this.skToolMenu.BaseItemAnamorphosis = true;
            this.skToolMenu.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.skToolMenu.BaseItemBorderShow = true;
            this.skToolMenu.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skToolMenu.BaseItemDown")));
            this.skToolMenu.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skToolMenu.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skToolMenu.BaseItemMouse")));
            this.skToolMenu.BaseItemPressed = System.Drawing.Color.Transparent;
            this.skToolMenu.BaseItemRadius = 2;
            this.skToolMenu.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skToolMenu.BaseItemSplitter = System.Drawing.Color.Transparent;
            this.skToolMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.skToolMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skToolMenu.Fore = System.Drawing.Color.Black;
            this.skToolMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skToolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skToolMenu.HoverFore = System.Drawing.Color.White;
            this.skToolMenu.ItemAnamorphosis = false;
            this.skToolMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skToolMenu.ItemBorderShow = false;
            this.skToolMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skToolMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skToolMenu.ItemRadius = 3;
            this.skToolMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.skToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFont,
            this.toolStripButtonEmotion,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton7});
            this.skToolMenu.Location = new System.Drawing.Point(1, 410);
            this.skToolMenu.Name = "skToolMenu";
            this.skToolMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skToolMenu.Size = new System.Drawing.Size(462, 27);
            this.skToolMenu.SkinAllColor = true;
            this.skToolMenu.TabIndex = 132;
            this.skToolMenu.Text = "skinToolStrip1";
            this.skToolMenu.TitleAnamorphosis = false;
            this.skToolMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skToolMenu.TitleRadius = 4;
            this.skToolMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolFont
            // 
            this.toolFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFont.Image = ((System.Drawing.Image)(resources.GetObject("toolFont.Image")));
            this.toolFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFont.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
            this.toolFont.Name = "toolFont";
            this.toolFont.Size = new System.Drawing.Size(23, 24);
            this.toolFont.Text = "toolStripButton1";
            this.toolFont.ToolTipText = "字体选择工具栏";
            this.toolFont.Click += new System.EventHandler(this.toolFont_Click);
            // 
            // toolStripButtonEmotion
            // 
            this.toolStripButtonEmotion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEmotion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEmotion.Image")));
            this.toolStripButtonEmotion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEmotion.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripButtonEmotion.Name = "toolStripButtonEmotion";
            this.toolStripButtonEmotion.Size = new System.Drawing.Size(23, 24);
            this.toolStripButtonEmotion.Text = "toolStripButton2";
            this.toolStripButtonEmotion.ToolTipText = "选择表情";
            this.toolStripButtonEmotion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButtonEmotion_MouseUp);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton3.Text = "手写板";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton2.Text = "屏幕截图";
            this.toolStripButton2.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::GGTalk.Properties.Resources.Conversation;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 24);
            this.toolStripButton1.Text = "消息记录";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton7.Text = "发送图片（支持Gif）";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // label_announce
            // 
            this.label_announce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_announce.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.label_announce.AutoSize = true;
            this.label_announce.BackColor = System.Drawing.Color.Transparent;
            this.label_announce.BorderColor = System.Drawing.Color.White;
            this.label_announce.BorderSize = 4;
            this.label_announce.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label_announce.ForeColor = System.Drawing.Color.Black;
            this.label_announce.Location = new System.Drawing.Point(57, 35);
            this.label_announce.Name = "label_announce";
            this.label_announce.Size = new System.Drawing.Size(226, 17);
            this.label_announce.TabIndex = 103;
            this.label_announce.Text = "2.10上午10点一号会议室全体员工大会！";
            // 
            // gifBox_wait
            // 
            this.gifBox_wait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gifBox_wait.BackColor = System.Drawing.Color.Transparent;
            this.gifBox_wait.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox_wait.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox_wait.Image = global::GGTalk.Properties.Resources.busy;
            this.gifBox_wait.Location = new System.Drawing.Point(280, 532);
            this.gifBox_wait.Name = "gifBox_wait";
            this.gifBox_wait.Size = new System.Drawing.Size(20, 20);
            this.gifBox_wait.TabIndex = 141;
            this.gifBox_wait.Text = "gifBox1";
            this.gifBox_wait.Visible = false;
            // 
            // chatBoxSend
            // 
            this.chatBoxSend.AllowDrop = true;
            this.chatBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBoxSend.ContextMenuMode = JustLib.Controls.ChatBoxContextMenuMode.ForInput;
            this.chatBoxSend.Location = new System.Drawing.Point(1, 438);
            this.chatBoxSend.Name = "chatBoxSend";
            this.chatBoxSend.PopoutImageWhenDoubleClick = false;
            this.chatBoxSend.Size = new System.Drawing.Size(462, 89);
            this.chatBoxSend.TabIndex = 140;
            this.chatBoxSend.Text = "";
            // 
            // chatBox_history
            // 
            this.chatBox_history.AllowDrop = true;
            this.chatBox_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox_history.BackColor = System.Drawing.Color.White;
            this.chatBox_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox_history.ContextMenuMode = JustLib.Controls.ChatBoxContextMenuMode.ForOutput;
            this.chatBox_history.Location = new System.Drawing.Point(1, 89);
            this.chatBox_history.Name = "chatBox_history";
            this.chatBox_history.PopoutImageWhenDoubleClick = true;
            this.chatBox_history.ReadOnly = true;
            this.chatBox_history.Size = new System.Drawing.Size(462, 320);
            this.chatBox_history.TabIndex = 139;
            this.chatBox_history.Text = "";
            // 
            // GroupChatForm
            // 
            this.AcceptButton = this.skinButton_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BorderPalace = global::GGTalk.Properties.Resources.BackPalace;
            this.CancelButton = this.btnClose;
            this.CanResize = true;
            this.ClientSize = new System.Drawing.Size(670, 565);
            this.CloseDownBack = global::GGTalk.Properties.Resources.btn_close_down;
            this.CloseMouseBack = global::GGTalk.Properties.Resources.btn_close_highlight;
            this.CloseNormlBack = global::GGTalk.Properties.Resources.btn_close_disable;
            this.Controls.Add(this.skinToolStrip2);
            this.Controls.Add(this.gifBox_wait);
            this.Controls.Add(this.chatBoxSend);
            this.Controls.Add(this.chatBox_history);
            this.Controls.Add(this.chatListBox1);
            this.Controls.Add(this.linkLabel_softName);
            this.Controls.Add(this.skinButton_send);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlTx);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.skToolMenu);
            this.Controls.Add(this.label_announce);
            this.EffectCaption = CCWin.TitleType.None;
            this.EffectWidth = 4;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = global::GGTalk.Properties.Resources.btn_max_down;
            this.MaximizeBox = true;
            this.MaxMouseBack = global::GGTalk.Properties.Resources.btn_max_highlight;
            this.MaxNormlBack = global::GGTalk.Properties.Resources.btn_max_normal;
            this.MiniDownBack = global::GGTalk.Properties.Resources.btn_mini_down;
            this.MinimizeBox = true;
            this.MiniMouseBack = global::GGTalk.Properties.Resources.btn_mini_highlight;
            this.MinimumSize = new System.Drawing.Size(630, 490);
            this.MiniNormlBack = global::GGTalk.Properties.Resources.btn_mini_normal;
            this.Name = "GroupChatForm";
            this.RestoreDownBack = global::GGTalk.Properties.Resources.btn_restore_down;
            this.RestoreMouseBack = global::GGTalk.Properties.Resources.btn_restore_highlight;
            this.RestoreNormlBack = global::GGTalk.Properties.Resources.btn_restore_normal;
            this.Shadow = false;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = true;
            this.Special = false;
            this.TopMost = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.GroupChatForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmChat_Paint);
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.pnlTx.ResumeLayout(false);
            this.skToolMenu.ResumeLayout(false);
            this.skToolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private CCWin.SkinControl.SkinLabel labelGroupName;
        private CCWin.SkinControl.SkinLabel label_announce;
        private CCWin.SkinControl.SkinPanel pnlTx;
        private CCWin.SkinControl.SkinPanel panelFriendHeadImage;
        private System.Windows.Forms.ToolTip toolShow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private CCWin.SkinControl.SkinToolStrip skToolMenu;
        private System.Windows.Forms.ToolStripButton toolFont;
        private System.Windows.Forms.ToolStripButton toolStripButtonEmotion;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private CCWin.SkinControl.ChatListBox chatListBox1;
        private CCWin.SkinControl.SkinButton btnClose;
        private System.Windows.Forms.LinkLabel linkLabel_softName;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private CCWin.SkinControl.SkinButton skinButton_send;
        private ChatBox chatBox_history;
        private ChatBox chatBoxSend;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private GifBox gifBox_wait;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 视频聊天ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 语音视频设备测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem 语音聊天ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 语音视频设备测试ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton ToolFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ToolStripMenuItem 发送离线文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem 请求远程协助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桌面共享指定区域ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_adduser;
    }
}