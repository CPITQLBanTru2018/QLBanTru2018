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
            grDanhSachLopHoc.DataSource = dt.ListClass();
        }

        private void USCacKhoanThuTheoLop_Load(object sender, EventArgs e)
        {
            LoadNamhoc();
            studentReceivableDAO.CourseID = (int)cbbNamhoc.SelectedValue;
            LoadHocky();
            studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
            LoadKhoihoc();
            studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
            LoadLophoc();
        }
        public void LoadDSLop()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            grDanhSachHocSinh.DataSource = dt.ListStudents();
        }

        private void cbbNamhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            studentReceivableDAO.CourseID = (int)cbbNamhoc.SelectedValue;
            studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
            studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
            LoadHocky();
            LoadKhoihoc();
            LoadLophoc();
        }

        private void cbbHocky_SelectionChangeCommitted(object sender, EventArgs e)
        {
            studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
            studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
            LoadKhoihoc();
            LoadLophoc();
        }

        private void cbbKhoihoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            studentReceivableDAO.GradeID =(int) cbbKhoihoc.SelectedValue;
            LoadLophoc();
        }

        private void cbbLophoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            studentReceivableDAO.ClassID= (int)gridView2.GetRowCellValue(e.FocusedRowHandle, "ClassID");
            LoadDSLop();
        }
    }
}
