using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataConnect;
using DataConnect.DAO.ThanhCongTC;
using QLHSBanTru2018_Demo_V1.QLThuChi.DotThu.KeHoachThu;

namespace QLHSBanTru2018_Demo_V1.QLThuChi
{
    public partial class FTaoKhoanThu : DevExpress.XtraEditors.XtraForm
    {
        public FTaoKhoanThu()
        {
            InitializeComponent();
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadHocKy()
        {
            SemesterDAO dt = new SemesterDAO();
            cbbNamhoc.DataSource = dt.ListSemester();
            cbbNamhoc.ValueMember = "SemesterID";
            cbbNamhoc.DisplayMember = "Name";
        }
        private void bntDienMienGiam_Click(object sender, EventArgs e)
        {
            FRDienMienGiam a = new FRDienMienGiam();
            a.ShowDialog();
        }
        public void loadKhoi()
        {
            GradeDAO dt = new GradeDAO();
            cbbKhoihoc.DataSource = dt.listGrade(int.Parse(cbbNamhoc.SelectedValue.ToString()));
            cbbKhoihoc.ValueMember = "GradeID";
            cbbKhoihoc.DisplayMember = "Name";
        }
        private void bntLuu_Click(object sender, EventArgs e)
        {

            try
            {
                
                ReceivableDetail a = new ReceivableDetail();
                a.Name = txtTenKhoanThu.Text;
                a.Price = decimal.Parse(txtMucThu.Text);
                a.Status = true;
                ReceivableDetailDAO.ListDemoReceivableDetail.Add(a);
                this.Close();
            }
            catch 
            {

                
            }
        }

        private void FTaoKhoanThu_Load(object sender, EventArgs e)
        {
            loadHocKy();
            loadKhoi();
        }

        private void cbDoituongchinhsach_CheckedChanged(object sender, EventArgs e)
        {
            if (bntDoituongchinhsach.Enabled == false)
            {
                bntDoituongchinhsach.Enabled = true;
            }
            else
            {
                bntDoituongchinhsach.Enabled = false;
            }
        }

        private void bntDoituongchinhsach_Click(object sender, EventArgs e)
        {
            FrDoiTuongchinhsach a = new FrDoiTuongchinhsach();
            a.ShowDialog();
        }
    }
}