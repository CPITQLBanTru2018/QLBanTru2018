﻿namespace QLHSBanTru2018_Demo_V1.QLThuChi
{
    partial class FTaoKhoanThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTaoKhoanThu));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhoanThu = new System.Windows.Forms.TextBox();
            this.bntLuu = new DevExpress.XtraEditors.SimpleButton();
            this.bntHuy = new DevExpress.XtraEditors.SimpleButton();
            this.cbbNhomThu = new System.Windows.Forms.ComboBox();
            this.cbHangThang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMucThu = new System.Windows.Forms.TextBox();
            this.txtSoBuoi = new System.Windows.Forms.TextBox();
            this.cbHocKy = new System.Windows.Forms.RadioButton();
            this.cbNam = new System.Windows.Forms.RadioButton();
            this.txtThoiDiemThu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDonViThoiGian = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntDienMienGiam = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khoản thu";
            // 
            // txtTenKhoanThu
            // 
            this.txtTenKhoanThu.Location = new System.Drawing.Point(94, 12);
            this.txtTenKhoanThu.Name = "txtTenKhoanThu";
            this.txtTenKhoanThu.Size = new System.Drawing.Size(228, 21);
            this.txtTenKhoanThu.TabIndex = 1;
            // 
            // bntLuu
            // 
            this.bntLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntLuu.ImageOptions.Image")));
            this.bntLuu.Location = new System.Drawing.Point(157, 240);
            this.bntLuu.Name = "bntLuu";
            this.bntLuu.Size = new System.Drawing.Size(75, 23);
            this.bntLuu.TabIndex = 2;
            this.bntLuu.Text = "Lưu";
            this.bntLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntHuy.ImageOptions.Image")));
            this.bntHuy.Location = new System.Drawing.Point(247, 240);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(75, 23);
            this.bntHuy.TabIndex = 4;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // cbbNhomThu
            // 
            this.cbbNhomThu.FormattingEnabled = true;
            this.cbbNhomThu.Items.AddRange(new object[] {
            "Thu định kỳ",
            "Thu phát sinh"});
            this.cbbNhomThu.Location = new System.Drawing.Point(94, 44);
            this.cbbNhomThu.Name = "cbbNhomThu";
            this.cbbNhomThu.Size = new System.Drawing.Size(228, 21);
            this.cbbNhomThu.TabIndex = 5;
            // 
            // cbHangThang
            // 
            this.cbHangThang.AutoSize = true;
            this.cbHangThang.Location = new System.Drawing.Point(94, 125);
            this.cbHangThang.Name = "cbHangThang";
            this.cbHangThang.Size = new System.Drawing.Size(81, 17);
            this.cbHangThang.TabIndex = 6;
            this.cbHangThang.TabStop = true;
            this.cbHangThang.Text = "Hàng tháng";
            this.cbHangThang.UseVisualStyleBackColor = true;
            this.cbHangThang.CheckedChanged += new System.EventHandler(this.cbHangThang_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thuộc nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mức thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số buổi/tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tần suất thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thời điểm thu";
            // 
            // txtMucThu
            // 
            this.txtMucThu.Location = new System.Drawing.Point(94, 71);
            this.txtMucThu.Name = "txtMucThu";
            this.txtMucThu.Size = new System.Drawing.Size(100, 21);
            this.txtMucThu.TabIndex = 14;
            // 
            // txtSoBuoi
            // 
            this.txtSoBuoi.Location = new System.Drawing.Point(94, 98);
            this.txtSoBuoi.Name = "txtSoBuoi";
            this.txtSoBuoi.Size = new System.Drawing.Size(228, 21);
            this.txtSoBuoi.TabIndex = 15;
            // 
            // cbHocKy
            // 
            this.cbHocKy.AutoSize = true;
            this.cbHocKy.Location = new System.Drawing.Point(192, 125);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(57, 17);
            this.cbHocKy.TabIndex = 16;
            this.cbHocKy.TabStop = true;
            this.cbHocKy.Text = "Học kỳ";
            this.cbHocKy.UseVisualStyleBackColor = true;
            this.cbHocKy.CheckedChanged += new System.EventHandler(this.cbHocKy_CheckedChanged);
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Location = new System.Drawing.Point(276, 125);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(46, 17);
            this.cbNam.TabIndex = 17;
            this.cbNam.TabStop = true;
            this.cbNam.Text = "Năm";
            this.cbNam.UseVisualStyleBackColor = true;
            this.cbNam.CheckedChanged += new System.EventHandler(this.cbNam_CheckedChanged);
            // 
            // txtThoiDiemThu
            // 
            this.txtThoiDiemThu.Location = new System.Drawing.Point(94, 148);
            this.txtThoiDiemThu.Name = "txtThoiDiemThu";
            this.txtThoiDiemThu.Size = new System.Drawing.Size(228, 21);
            this.txtThoiDiemThu.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "/";
            // 
            // cbbDonViThoiGian
            // 
            this.cbbDonViThoiGian.FormattingEnabled = true;
            this.cbbDonViThoiGian.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Học kỳ",
            "Năm"});
            this.cbbDonViThoiGian.Location = new System.Drawing.Point(222, 71);
            this.cbbDonViThoiGian.Name = "cbbDonViThoiGian";
            this.cbbDonViThoiGian.Size = new System.Drawing.Size(100, 21);
            this.cbbDonViThoiGian.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 10);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // bntDienMienGiam
            // 
            this.bntDienMienGiam.Location = new System.Drawing.Point(192, 175);
            this.bntDienMienGiam.Name = "bntDienMienGiam";
            this.bntDienMienGiam.Size = new System.Drawing.Size(130, 23);
            this.bntDienMienGiam.TabIndex = 22;
            this.bntDienMienGiam.Text = "Diện miễn giảm";
            this.bntDienMienGiam.Click += new System.EventHandler(this.bntDienMienGiam_Click);
            // 
            // FTaoKhoanThu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 267);
            this.Controls.Add(this.bntDienMienGiam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbDonViThoiGian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtThoiDiemThu);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbHocKy);
            this.Controls.Add(this.txtSoBuoi);
            this.Controls.Add(this.txtMucThu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHangThang);
            this.Controls.Add(this.cbbNhomThu);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntLuu);
            this.Controls.Add(this.txtTenKhoanThu);
            this.Controls.Add(this.label1);
            this.Name = "FTaoKhoanThu";
            this.Text = "Tạo khoản thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhoanThu;
        private DevExpress.XtraEditors.SimpleButton bntLuu;
        private DevExpress.XtraEditors.SimpleButton bntHuy;
        private System.Windows.Forms.ComboBox cbbNhomThu;
        private System.Windows.Forms.RadioButton cbHangThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMucThu;
        private System.Windows.Forms.TextBox txtSoBuoi;
        private System.Windows.Forms.RadioButton cbHocKy;
        private System.Windows.Forms.RadioButton cbNam;
        private System.Windows.Forms.TextBox txtThoiDiemThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbDonViThoiGian;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton bntDienMienGiam;
    }
}