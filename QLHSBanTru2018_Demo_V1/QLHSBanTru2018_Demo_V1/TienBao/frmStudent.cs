using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataConnect.DAO.TienBao;
using DataConnect.DAO.HungTD;
using System.IO;
using System.Drawing.Imaging;

namespace QLHSBanTru2018_Demo_V1.TienBao
{
    public partial class frmStudent : DevExpress.XtraEditors.XtraUserControl
    {
        #region System
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            combobox_Defaule();

            cmbNamHoc_SelectedIndexChanged(sender, e);
            cmbHocKy_SelectedIndexChanged(sender, e);
            cmbKhoiHoc_SelectedIndexChanged(sender, e);
            cmbLopHoc_SelectedIndexChanged(sender, e);

        }
        #endregion

        #region LoadInfor
        private void LoadClassInfor(int GradeID)
        {
            List<DataConnect.Class> listClass = new ClassDAO().ListClassByGrade(GradeID);
            cmbLopHoc.DisplayMember= "Name";
            cmbLopHoc.ValueMember = "ClassID";
            cmbLopHoc.DataSource = listClass;
        }

        private void LoadGradeInfor(int SemesterID)
        {
            List<DataConnect.Grade> ListGrade = new GradeDAO().ListBySemester(SemesterID);
            cmbKhoiLop.DisplayMember = "Name";
            cmbKhoiLop.ValueMember = "GradeID";
            cmbKhoiLop.DataSource = ListGrade;
        }

        private void LoadSemesterInfor(int CourseID)
        {
            List<DataConnect.Semester> ListSemester = new SemesterDAO().ListByCourseID(CourseID);
            cmbHocKy.DisplayMember = "Name";
            cmbHocKy.ValueMember = "SemesterID";
            cmbHocKy.DataSource = ListSemester;
        }

        private void LoadCourseInfor()
        {
            List<DataConnect.Course> ListCourse = new CourseDAO().ListAll();
            cmbNamHoc.DataSource = ListCourse;
            cmbNamHoc.DisplayMember = "Name";
            cmbNamHoc.ValueMember = "CourseID";
        }

        private void FillGridControl(int ClassID)
        {
            try
            {
                dgvHocSinh.DataSource = new StudentDAO().ListStudentByClass(ClassID);
            }
            catch
            { }
        }

        private void BindingDetail()
        {
            txtStudentID.DataBindings.Clear();
            txtStudentCode.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            dtBirthday.DataBindings.Clear();
            radMale.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            radActive.DataBindings.Clear();
            picImage.DataBindings.Clear();
            txtFatherName.DataBindings.Clear();
            txtFatherJob.DataBindings.Clear();
            txtMotherName.DataBindings.Clear();
            txtMotherJob.DataBindings.Clear();
            txtStudentCode.DataBindings.Add("text", dgvHocSinh.DataSource, "StudentCode");
            txtStudentID.DataBindings.Add("text", dgvHocSinh.DataSource, "StudentID");
            txtFirstName.DataBindings.Add("text", dgvHocSinh.DataSource, "FirstName");
            txtLastName.DataBindings.Add("text", dgvHocSinh.DataSource, "LastName");
            dtBirthday.DataBindings.Add("value", dgvHocSinh.DataSource, "Birthday");
            radMale.DataBindings.Add("Checked", dgvHocSinh.DataSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAddress.DataBindings.Add("text", dgvHocSinh.DataSource, "AdressDetail");
            picImage.DataBindings.Add("image", dgvHocSinh.DataSource, "Image", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFatherName.DataBindings.Add("text", dgvHocSinh.DataSource, "FatherName");
            txtFatherJob.DataBindings.Add("text", dgvHocSinh.DataSource, "FatherJob");
            txtMotherName.DataBindings.Add("text", dgvHocSinh.DataSource, "MotherName");
            txtMotherJob.DataBindings.Add("text", dgvHocSinh.DataSource, "MotherJob");
            radActive.DataBindings.Add("Checked", dgvHocSinh.DataSource, "Status", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        void combobox_Defaule()
        {
            cmbNamHoc.Text = "-- Chọn năm học --";
            cmbHocKy.Text = "-- Chọn học kỳ --";
            cmbKhoiLop.Text = "-- Chọn khối lớp --";
            cmbLopHoc.Text = "-- Chọn lớp học --";
            cmbTrangThai.Text = "-- Chọn trạng thái --";
        }
        #endregion

        #region Event

        private void cmbNamHoc_Click(object sender, EventArgs e)
        {
            LoadCourseInfor();
        }
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadSemesterInfor(int.Parse(cmbNamHoc.SelectedValue.ToString()));
            }
            catch
            {
            }
        }
        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadGradeInfor(int.Parse(cmbHocKy.SelectedValue.ToString()));

            }
            catch
            {
            }
        }
        private void cmbKhoiHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadClassInfor(int.Parse(cmbKhoiLop.SelectedValue.ToString()));

            }
            catch
            {
            }
        }
        private void cmbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
                BindingDetail();
            }
            catch
            {
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            combobox_Defaule();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmStudentDetail StudentDetail = new frmStudentDetail();
            StudentDetail.iFunction = 1;
            StudentDetail.ShowDialog();
            if (StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }
        #endregion




        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtStudentID.Text = bandedGridView1.GetRowCellValue(e.FocusedRowHandle, "StudentID").ToString();
            txtStudentCode.Text = bandedGridView1.GetRowCellValue(e.FocusedRowHandle, "StudentCode").ToString();
            txtFirstName.Text = bandedGridView1.GetRowCellValue(e.FocusedRowHandle, "FirstName").ToString();
            txtLastName.Text = bandedGridView1.GetRowCellValue(e.FocusedRowHandle, "LastName").ToString();
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            frmStudentDetail StudentDetail = new frmStudentDetail();
            StudentDetail.ShowDialog();
        }

       
    }
}
