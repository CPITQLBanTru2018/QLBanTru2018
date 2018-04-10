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

namespace QLHSBanTru2018_Demo_V1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Trần Đức Hùng
        private void btnDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmDepartmentList());
        }

        private void btnEmployeeManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmEmployeeList());
        }
        private void btnPosition_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmPositionList());
        }

        private void btnCourse_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmCourseList());
        }

        private void btnAddFunction_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmFunctionList().ShowDialog();
        }

        private void btnContractManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmContractList());
        }

        private void btnSemester_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmSemesterList());
        }
        private void btnTopicLesson_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmTopicLesson());
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
        #endregion

        #region Vũ Đức Thiện

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

        
    }
}