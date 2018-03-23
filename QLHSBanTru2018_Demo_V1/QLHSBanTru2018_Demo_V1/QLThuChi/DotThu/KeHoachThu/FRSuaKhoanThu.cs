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
using System.Threading;

namespace QLHSBanTru2018_Demo_V1.QLThuChi
{
    public partial class FRSuaKhoanThu : DevExpress.XtraEditors.XtraForm
    {
        public FRSuaKhoanThu()
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
                cbHangThang.Checked = false;
                cbHocKy.Checked = false;
            }
        }
    }
}