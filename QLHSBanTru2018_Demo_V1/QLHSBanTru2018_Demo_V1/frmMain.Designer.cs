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
            this.bntDotThu = new DevExpress.XtraBars.BarButtonItem();
            this.bntThuTheoLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddFunction = new DevExpress.XtraBars.BarButtonItem();
            this.btnContractManager = new DevExpress.XtraBars.BarButtonItem();
            this.btnTTHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pnControlsPanel = new System.Windows.Forms.Panel();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnCourse,
            this.bntDotThu,
            this.bntThuTheoLop,
            this.btnAddFunction,
            this.btnContractManager,
            this.btnTTHocSinh,
            this.btnTKHocSinh,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(798, 146);
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
            // bntDotThu
            // 
            this.bntDotThu.Caption = "Đợt thu";
            this.bntDotThu.Id = 5;
            this.bntDotThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntDotThu.ImageOptions.Image")));
            this.bntDotThu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntDotThu.ImageOptions.LargeImage")));
            this.bntDotThu.Name = "bntDotThu";
            this.bntDotThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntDotThu_ItemClick);
            // 
            // bntThuTheoLop
            // 
            this.bntThuTheoLop.Caption = "Thu Theo lớp";
            this.bntThuTheoLop.Id = 6;
            this.bntThuTheoLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntThuTheoLop.ImageOptions.Image")));
            this.bntThuTheoLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bntThuTheoLop.ImageOptions.LargeImage")));
            this.bntThuTheoLop.Name = "bntThuTheoLop";
            this.bntThuTheoLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntThuTheoLop_ItemClick);
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.Caption = "Thêm Mới Chức Năng";
            this.btnAddFunction.Id = 7;
            this.btnAddFunction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFunction.ImageOptions.Image")));
            this.btnAddFunction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddFunction.ImageOptions.LargeImage")));
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddFunction_ItemClick);
            // 
            // btnContractManager
            // 
            this.btnContractManager.Caption = "Quản Lý Hợp Đồng";
            this.btnContractManager.Id = 8;
            this.btnContractManager.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnContractManager.ImageOptions.Image")));
            this.btnContractManager.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnContractManager.ImageOptions.LargeImage")));
            this.btnContractManager.Name = "btnContractManager";
            this.btnContractManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContractManager_ItemClick);
            // 
            // btnTTHocSinh
            // 
            this.btnTTHocSinh.Caption = "Thông tin học sinh";
            this.btnTTHocSinh.Id = 9;
            this.btnTTHocSinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTTHocSinh.ImageOptions.Image")));
            this.btnTTHocSinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTTHocSinh.ImageOptions.LargeImage")));
            this.btnTTHocSinh.Name = "btnTTHocSinh";
            this.btnTTHocSinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTTHocSinh_ItemClick);
            // 
            // btnTKHocSinh
            // 
            this.btnTKHocSinh.Caption = "Tài khoản học sinh";
            this.btnTKHocSinh.Id = 10;
            this.btnTKHocSinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKHocSinh.ImageOptions.Image")));
            this.btnTKHocSinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTKHocSinh.ImageOptions.LargeImage")));
            this.btnTKHocSinh.Name = "btnTKHocSinh";
            this.btnTKHocSinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKHocSinh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
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
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAddFunction);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Dành cho nhà phát triển";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnContractManager);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Hợp Đồng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Thu Chi";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bntDotThu);
            this.ribbonPageGroup3.ItemLinks.Add(this.bntThuTheoLop);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Khoản thu - đợt thu";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Học Sinh";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTTHocSinh);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTKHocSinh);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Quản lý hồ sơ học sinh";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 578);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(798, 21);
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
            this.pnControlsPanel.Size = new System.Drawing.Size(798, 432);
            this.pnControlsPanel.TabIndex = 3;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Dữ liệu học sinh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhập học sinh từ file Excel";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.pnControlsPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bntDotThu;
        private DevExpress.XtraBars.BarButtonItem bntThuTheoLop;
        private DevExpress.XtraBars.BarButtonItem btnAddFunction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnContractManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnTTHocSinh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnTKHocSinh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}