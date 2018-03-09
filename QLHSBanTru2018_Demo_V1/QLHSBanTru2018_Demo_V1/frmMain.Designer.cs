namespace QLHSBanTru2018_Demo_V1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployeeManager = new DevExpress.XtraBars.BarButtonItem();
            this.btnPosition = new DevExpress.XtraBars.BarButtonItem();
            this.btnCourse = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pnControlsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDepartment,
            this.btnEmployeeManager,
            this.btnPosition,
            this.btnCourse});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1372, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDepartment
            // 
            this.btnDepartment.Caption = "Phòng Ban";
            this.btnDepartment.Id = 1;
            this.btnDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartment.ImageOptions.Image")));
            this.btnDepartment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDepartment.ImageOptions.LargeImage")));
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepartment_ItemClick);
            // 
            // btnEmployeeManager
            // 
            this.btnEmployeeManager.Caption = "Nhân Viên";
            this.btnEmployeeManager.Id = 2;
            this.btnEmployeeManager.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManager.ImageOptions.Image")));
            this.btnEmployeeManager.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManager.ImageOptions.LargeImage")));
            this.btnEmployeeManager.Name = "btnEmployeeManager";
            this.btnEmployeeManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployeeManager_ItemClick);
            // 
            // btnPosition
            // 
            this.btnPosition.Caption = "Chức Vụ";
            this.btnPosition.Id = 3;
            this.btnPosition.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPosition.ImageOptions.Image")));
            this.btnPosition.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPosition.ImageOptions.LargeImage")));
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPosition_ItemClick);
            // 
            // btnCourse
            // 
            this.btnCourse.Caption = "Khóa Học";
            this.btnCourse.Id = 4;
            this.btnCourse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCourse.ImageOptions.Image")));
            this.btnCourse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCourse.ImageOptions.LargeImage")));
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCourse_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tổ Chức";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDepartment);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCourse);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPosition);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tổ Chức";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEmployeeManager);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản Lý Nhân Viên";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 746);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1372, 21);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // pnControlsPanel
            // 
            this.pnControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlsPanel.Location = new System.Drawing.Point(0, 146);
            this.pnControlsPanel.Name = "pnControlsPanel";
            this.pnControlsPanel.Size = new System.Drawing.Size(1372, 600);
            this.pnControlsPanel.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 767);
            this.Controls.Add(this.pnControlsPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần Mềm Quản Lý Học Sinh Bán Trú";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnDepartment;
        private System.Windows.Forms.Panel pnControlsPanel;
        private DevExpress.XtraBars.BarButtonItem btnEmployeeManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnPosition;
        private DevExpress.XtraBars.BarButtonItem btnCourse;
    }
}