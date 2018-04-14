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
using DataConnect.DAO.ThanhCongTC;

namespace QLHSBanTru2018_Demo_V1.QLThuChi.DotThu.KeHoachThu
{
    public partial class FRViewDoituongchinhsach : DevExpress.XtraEditors.XtraForm
    {
        public FRViewDoituongchinhsach()
        {
            InitializeComponent();
        }
        public void laodPreferred()
        {
            for (int i = 0; i <= studentReceivableDAO.PreferredID.Length-2; i++)
            {
                string a = studentReceivableDAO.PreferredID.Substring(i, i + 1);
                i++;
                MessageBox.Show("" + a + "");
            }
        }
        private void FRViewDoituongchinhsach_Load(object sender, EventArgs e)
        {
            //laodPreferred();
        }
    }
}