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

        private void bntDienMienGiam_Click(object sender, EventArgs e)
        {
            FRDienMienGiam a = new FRDienMienGiam();
            a.ShowDialog();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {

            try
            {
                ReceivableDetail_Preferred b = new ReceivableDetail_Preferred();
                b.PreferredID = (int)cbbMiengiam.SelectedValue;
                b.Percent = int.Parse(txtMucgiam.Text);
                ReceivableDetail_PreferredDAO.ListDemoReceivableDetail.Add(b);
                ReceivableDetail a = new ReceivableDetail();
                a.Name = txtTenKhoanThu.Text;
                a.Price = decimal.Parse(txtMucThu.Text);
                a.SalePrice = 0;
                a.Status = true;
                ReceivableDetailDAO.ListDemoReceivableDetail.Add(a);
                this.Close();
            }
            catch 
            {

                
            }
        }

        private void cbHangThang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHangThang.Checked==true)
            {
                cbHocKy.Checked = false;
                cbNam.Checked = false;
            }
        }

        private void cbHocKy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHocKy.Checked==true)
            {
                cbHangThang.Checked = false;
                cbNam.Checked = false;
            }
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked==true)
            {
                cbHocKy.Checked = false;
                cbHangThang.Checked = false;
            }
        }
        public void LoadDSMG()
        {
            PreferredDAO dt = new PreferredDAO();
            cbbMiengiam.DataSource = dt.ListPreferred();
            cbbMiengiam.ValueMember = "PreferredID";
            cbbMiengiam.DisplayMember = "Name";

        }
        private void FTaoKhoanThu_Load(object sender, EventArgs e)
        {
            LoadDSMG();
        }
    }
}