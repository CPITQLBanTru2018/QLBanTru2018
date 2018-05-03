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

namespace QLHSBanTru2018_Demo_V1.QLThuChi.ChiTieu
{
    public partial class UsKhoanChi : DevExpress.XtraEditors.XtraUserControl
    {
        public UsKhoanChi()
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

        private void UsKhoanChi_Load(object sender, EventArgs e)
        {
            LoadNamhoc();
            LoadHocky();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            FrThemkhoanchi a = new FrThemkhoanchi();
            a.ShowDialog();
        }
    }
}
