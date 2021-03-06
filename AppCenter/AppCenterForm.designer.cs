﻿namespace HiWhs.AppCenter.UI
{
    partial class AppCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppCenterForm));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer5 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.navBarGroupControlContainer4 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this._bbiEmp = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup6 = new DevExpress.XtraNavBar.NavBarGroup();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer2);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer4);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer5);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup5,
            this.navBarGroup6,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this._bbiEmp,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInGroup;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.NavigationPaneMaxVisibleGroups = 0;
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 269;
            this.navBarControl1.OptionsNavPane.ShowExpandButton = false;
            this.navBarControl1.OptionsNavPane.ShowGroupImageInHeader = true;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowSplitter = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(269, 588);
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "登录";
            this.navBarControl1.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl1_ActiveGroupChanged);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "关于";
            this.navBarGroup4.ControlContainer = this.navBarGroupControlContainer5;
            this.navBarGroup4.GroupClientHeight = 80;
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup4.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.LargeImage")));
            this.navBarGroup4.Name = "navBarGroup4";
            this.navBarGroup4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.SmallImage")));
            // 
            // navBarGroupControlContainer5
            // 
            this.navBarGroupControlContainer5.Controls.Add(this.memoEdit2);
            this.navBarGroupControlContainer5.Name = "navBarGroupControlContainer5";
            this.navBarGroupControlContainer5.Size = new System.Drawing.Size(269, 504);
            this.navBarGroupControlContainer5.TabIndex = 4;
            // 
            // memoEdit2
            // 
            this.memoEdit2.EditValue = "所有子系统入口、接管系统级权限、单点登录、子系统自动更新、等";
            this.memoEdit2.Location = new System.Drawing.Point(49, 50);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(176, 392);
            this.memoEdit2.TabIndex = 0;
            this.memoEdit2.EditValueChanged += new System.EventHandler(this.memoEdit2_EditValueChanged);
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.simpleButton1);
            this.navBarGroupControlContainer1.Controls.Add(this.textEdit1);
            this.navBarGroupControlContainer1.Controls.Add(this.textEdit2);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(269, 504);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(109, 126);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(109, 88);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(109, 48);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(269, 504);
            this.navBarGroupControlContainer2.TabIndex = 1;
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(269, 504);
            this.navBarGroupControlContainer3.TabIndex = 2;
            // 
            // navBarGroupControlContainer4
            // 
            this.navBarGroupControlContainer4.Name = "navBarGroupControlContainer4";
            this.navBarGroupControlContainer4.Size = new System.Drawing.Size(269, 504);
            this.navBarGroupControlContainer4.TabIndex = 3;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "系统";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this._bbiEmp),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.LargeImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SelectedLinkIndex = 6;
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // _bbiEmp
            // 
            this._bbiEmp.Caption = "企业管理平台";
            this._bbiEmp.LargeImage = ((System.Drawing.Image)(resources.GetObject("_bbiEmp.LargeImage")));
            this._bbiEmp.Name = "_bbiEmp";
            this._bbiEmp.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this._bbiEmp_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "门店管理平台";
            this.navBarItem4.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.LargeImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "供应链";
            this.navBarItem3.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.LargeImage")));
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "制造执行系统";
            this.navBarItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.LargeImage")));
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "报表中心";
            this.navBarItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.LargeImage")));
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "标准体系";
            this.navBarItem5.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.LargeImage")));
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "价格体系";
            this.navBarItem6.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.LargeImage")));
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "登录";
            this.navBarGroup2.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup2.GroupClientHeight = 80;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup2.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.LargeImage")));
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.SmallImage")));
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "设置";
            this.navBarGroup3.ControlContainer = this.navBarGroupControlContainer2;
            this.navBarGroup3.GroupClientHeight = 80;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup3.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.LargeImage")));
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.SmallImage")));
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "通知";
            this.navBarGroup5.ControlContainer = this.navBarGroupControlContainer3;
            this.navBarGroup5.GroupClientHeight = 80;
            this.navBarGroup5.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup5.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup5.LargeImage")));
            this.navBarGroup5.Name = "navBarGroup5";
            this.navBarGroup5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup5.SmallImage")));
            // 
            // navBarGroup6
            // 
            this.navBarGroup6.Caption = "收藏";
            this.navBarGroup6.ControlContainer = this.navBarGroupControlContainer4;
            this.navBarGroup6.GroupClientHeight = 80;
            this.navBarGroup6.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup6.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup6.LargeImage")));
            this.navBarGroup6.Name = "navBarGroup6";
            this.navBarGroup6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup6.SmallImage")));
            // 
            // _notifyIcon
            // 
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Text = "德贝应用中心";
            this._notifyIcon.Visible = true;
            this._notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this._notifyIcon_MouseClick);
            // 
            // AppCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 588);
            this.Controls.Add(this.navBarControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppCenterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "德贝应用中心";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraForm4_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem _bbiEmp;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup6;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer5;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
    }
}