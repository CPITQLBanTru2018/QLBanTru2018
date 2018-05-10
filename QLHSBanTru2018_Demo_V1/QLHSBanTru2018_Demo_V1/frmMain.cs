using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Department;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Employee;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Position;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Course;
using QLHSBanTru2018_Demo_V1.QLThuChi;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Function;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Contract;
using QLHSBanTru2018_Demo_V1.TienBao;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Semester;
using QLHSBanTru2018_Demo_V1.HungTD.Form.TopicLession;
using QLHSBanTru2018_Demo_V1.HungTD.Form.WorkProgress;
using QLHSBanTru2018_Demo_V1.DAO.HungTD;
using QLHSBanTru2018_Demo_V1.Common;
using QLHSBanTru2018_Demo_V1.Thien;


namespace QLHSBanTru2018_Demo_V1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            labNameLogin.Caption = "Nhân Viên Đăng Nhập: " + LoginDetail.LoginName;
        }
        #region Trần Đức Hùng
        private void btnDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmDepartmentList());
            labTitle.Caption = "QUẢN LÝ PHÒNG BAN";
        }

        private void btnEmployeeManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmEmployeeList());
            labTitle.Caption = "QUẢN LÝ NHÂN VIÊN";
        }
        private void btnPosition_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmPositionList());
            labTitle.Caption = "QUẢN LÝ CHỨC VỤ";
        }

        private void btnCourse_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmCourseList());
            labTitle.Caption = "QUẢN LÝ NĂM HỌC";
        }

        private void btnAddFunction_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmFunctionList().ShowDialog();
        }

        private void btnContractManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmContractList());
            labTitle.Caption = "QUẢN LÝ HỢP ĐỒNG";
        }

        private void btnSemester_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmSemesterList());
            labTitle.Caption = "QUẢN LÝ KỲ HỌC";
        }
        private void btnTopicLesson_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmTopicLesson());
            labTitle.Caption = "QUẢN LÝ BÀI GIẢNG";
        }
        private void btnWorkProgress_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmWorkProgressList());
            labTitle.Caption = "QUẢN LÝ QUÁ TRÌNH CÔNG TÁC";
        }
        #endregion

        #region Nguyễn Kiều Thành Công

        #endregion

        #region Nguyễn Tiến Bảo
        private void btnTTHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStudent m_Student = new frmStudent();
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(m_Student);
            m_Student.Dock = DockStyle.Fill;
        }

        private void btnTKHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmStudentACC m_Studentacc = new frmStudentACC();
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(m_Studentacc);
            m_Studentacc.Dock = DockStyle.Fill;
        }
        private void btnImportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmImportExcel m_frmImportExcel = new frmImportExcel();
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(m_frmImportExcel);
            m_frmImportExcel.Dock = DockStyle.Fill;
        }
        #endregion

        #region Vũ Đức Thiện
        private void btnDiemDanhHS_ItemClick(object sender, ItemClickEventArgs e)
        {
            DiemDanhHS a = new DiemDanhHS();
            a.ShowDialog();
        }

        private void btnNhanXet_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhanXetHangTuan a = new NhanXetHangTuan();
            a.ShowDialog();
        }

        private void btnTheodoidenmuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            TheoDoiDenMuon a = new TheoDoiDenMuon();
            a.ShowDialog();
        }
        #endregion

        private void bntDotThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsDotThuPhi a = new UsDotThuPhi();
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }

        private void bntThuTheoLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            USCacKhoanThuTheoLop a = new USCacKhoanThuTheoLop();
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}