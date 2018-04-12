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
using DataConnect.DAO.ThanhCongTC;
using System.IO;
using DataConnect;
using QLHSBanTru2018_Demo_V1.QLThuChi.DotThu.KeHoachThu;

namespace QLHSBanTru2018_Demo_V1.QLThuChi
{
    public partial class USCacKhoanThuTheoLop : DevExpress.XtraEditors.XtraUserControl
    {
        public USCacKhoanThuTheoLop()
        {
            InitializeComponent();
        }
        public void LoadNamhoc()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            cbbNamhoc.DataSource = dt.ListCourse();
            cbbNamhoc.ValueMember = "CourseID";
            cbbNamhoc.DisplayMember = "Name";
        }
        public void LoadHocky()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            cbbHocky.DataSource = dt.ListSemester();
            cbbHocky.ValueMember = "SemesterID";
            cbbHocky.DisplayMember = "Name";
        }
        public void LoadKhoihoc()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            cbbKhoihoc.DataSource = dt.ListGrade();
            cbbKhoihoc.ValueMember = "GradeID";
            cbbKhoihoc.DisplayMember = "Name";
        }
        public void LoadLophoc()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            //grDanhSachLopHoc.DataSource = dt.ListClass();
            cbbLophoc.DataSource = dt.ListClass();
            cbbLophoc.ValueMember = "ClassID";
            cbbLophoc.DisplayMember = "Name";
        }
        public void laodDotthu()
        {
            ReceivableIDAO dt = new ReceivableIDAO();
            cbbDotthu.DataSource = dt.ListReceivable();
            cbbDotthu.ValueMember = "ReceivableID";
            cbbDotthu.DisplayMember = "Name";
        }

        private void USCacKhoanThuTheoLop_Load(object sender, EventArgs e)
        {
            try
            {
                laodDotthu();
                LoadNamhoc();
                studentReceivableDAO.CourseID = (int)cbbNamhoc.SelectedValue;
                LoadHocky();
                studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
                LoadKhoihoc();
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                //loadDSHS();
            }
            catch 
            {

               
            }
        }
        public void LoadDSLop()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            grDanhSachHocSinh.DataSource = dt.ListStudents();
        }

        private void cbbNamhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                studentReceivableDAO.CourseID = (int)cbbNamhoc.SelectedValue;
                LoadHocky();
                studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
                LoadKhoihoc();
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                loadDSHS();
            }
            catch 
            {

                
            }
        }

        private void cbbHocky_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
                LoadKhoihoc();
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                loadDSHS();
            }
            catch 
            {

                
            }
        }

        private void cbbKhoihoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                loadDSHS();
            }
            catch 
            {

                
            }
        }
        public void loadDSHS()
        {
            ClassStudentDAO dt = new ClassStudentDAO();
            grDanhSachHocSinh.DataSource = dt.ListStudent((int)cbbLophoc.SelectedValue);
        }
        private void cbbLophoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //studentReceivableDAO.ClassID = (int)cbbDotthu.SelectedValue;
            loadDSHS();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ClassStudentDAO dt = new ClassStudentDAO();
                ClassStudentDAO.StudentID = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "StudentID");
                Student a = dt.lookForStuden(ClassStudentDAO.StudentID);
                txtTenhocsinh.Text = a.FirstName + " " + a.LastName;
                txtNgaySinh.Text = a.Birthday.ToString();
                txtDiachi.Text = a.AdressDetail;
                MemoryStream mom = new MemoryStream(a.Image.ToArray());
                Image b = Image.FromStream(mom);
                pcAnhhocsinh.Image = b;
            }
            catch 
            {

                
            }
        }

        private void cbbDotthu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ReceivableIDAO.ReceivableID = (int)cbbDotthu.SelectedValue;
        }

        private void bntThanhToan_Click(object sender, EventArgs e)
        {
            FrThanhToan a = new FrThanhToan();
            a.ShowDialog();
        }
    }
}
