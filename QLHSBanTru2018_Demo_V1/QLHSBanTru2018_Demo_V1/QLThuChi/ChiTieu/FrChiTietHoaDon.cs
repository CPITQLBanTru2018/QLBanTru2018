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

namespace QLHSBanTru2018_Demo_V1.QLThuChi.ChiTieu
{
    public partial class FrChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public FrChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void FrChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}