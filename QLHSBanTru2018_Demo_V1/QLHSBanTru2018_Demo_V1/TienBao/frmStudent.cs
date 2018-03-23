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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace QLHSBanTru2018_Demo_V1.TienBao
{
    public partial class frmStudent : DevExpress.XtraEditors.XtraUserControl
    {
        #region System
        public frmStudent()
        {
            InitializeComponent();
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
            List<DataConnect.Grade> ListGrade = new DataConnect.DAO.HungTD.GradeDAO().ListBySemester(SemesterID);
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
                BindingDetail();
            }
            catch
            { }
        }

        private void BindingDetail()
        {
            txtStudentCode.DataBindings.Clear();
            txtStudentCode.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "StudentCode"));
            txtStudentID.DataBindings.Clear();
            txtStudentID.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "StudentID"));
            txtFirstName.DataBindings.Clear();
            txtFirstName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "FirstName"));
            txtLastName.DataBindings.Clear();
            txtLastName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "LastName"));
            dtBirthday.DataBindings.Clear();
            dtBirthday.DataBindings.Add(new Binding("EditValue", dgvHocSinh.DataSource, "Birthday", true, DataSourceUpdateMode.OnPropertyChanged));         
            radMale.DataBindings.Clear();
            radMale.DataBindings.Add(new Binding("Checked", dgvHocSinh.DataSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged));
                                   
            picImage.DataBindings.Clear();
            picImage.DataBindings.Add(new Binding("image", dgvHocSinh.DataSource, "Image", true, DataSourceUpdateMode.OnPropertyChanged));
            //txtAddress.DataBindings.Clear();
            //txtAddress.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "AdressDetail"));
            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "LocationDetail"));
            radActive.DataBindings.Clear();
            radActive.DataBindings.Add(new Binding("Checked", dgvHocSinh.DataSource, "Status", true, DataSourceUpdateMode.OnPropertyChanged));
            txtFatherName.DataBindings.Clear();
            txtFatherName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "FatherName"));
            txtFatherJob.DataBindings.Clear();
            txtFatherJob.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "FatherJob"));
            txtMotherName.DataBindings.Clear();
            txtMotherName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "MotherName"));
            txtMotherJob.DataBindings.Clear();
            txtMotherJob.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "MotherJob"));
            
        }

        void combobox_Defaule()
        {
            cmbNamHoc.Text = "-- Chọn năm học --";
            cmbHocKy.Text = "-- Chọn học kỳ --";
            cmbKhoiLop.Text = "-- Chọn khối lớp --";
            cmbLopHoc.Text = "-- Chọn lớp học --";
            cmbTrangThai.Text = "-- Chọn trạng thái --";
        }

        void Enable_TextBox()
        {
            txtStudentCode.Enabled = false;
            txtStudentID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            dtBirthday.Enabled = false;
            txtAddress.Enabled = false;
            radMale.Enabled = false;
            radFemale.Enabled = false;
            radActive.Enabled = false;
            radLock.Enabled = false;
            txtFatherName.Enabled = false;
            txtFatherJob.Enabled = false;
            txtMotherName.Enabled = false;
            txtMotherJob.Enabled = false;
            LabelStatus.Enabled = false;
            LabelGender.Enabled = false;
        }
        #endregion

        #region Event
        private void frmStudent_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            combobox_Defaule();
            Enable_TextBox();
            cmbNamHoc_SelectedIndexChanged(sender, e);
            cmbHocKy_SelectedIndexChanged(sender, e);
            cmbKhoiHoc_SelectedIndexChanged(sender, e);
            cmbLopHoc_SelectedIndexChanged(sender, e);

        }
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
            if (StudentDetail.DialogResult == DialogResult.OK);               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 2;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 3;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa học sinh ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                new StudentDAO().StudentDelete(int.Parse(txtStudentID.Text));
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            }
        }
        #endregion




       

        #region ContextMenu
        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 3;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetail StudentDetail = new frmStudentDetail();
            StudentDetail.iFunction = 1;
            StudentDetail.ShowDialog();
            if (StudentDetail.DialogResult == DialogResult.OK) ;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 2;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa học sinh ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                new StudentDAO().StudentDelete(int.Parse(txtStudentID.Text));
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            }
        }
        #endregion

       
    }
}
