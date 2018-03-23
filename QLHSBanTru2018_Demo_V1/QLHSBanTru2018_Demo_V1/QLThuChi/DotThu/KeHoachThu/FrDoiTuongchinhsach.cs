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
    public partial class FrDoiTuongchinhsach : DevExpress.XtraEditors.XtraForm
    {
        public FrDoiTuongchinhsach()
        {
            InitializeComponent();
        }
        public void loadDoituongchinhsach()
        {
            PreferredDAO dt = new PreferredDAO();
            grDoituongchinhsach.DataSource = dt.ListPreferred();
        }
        private void FrDoiTuongchinhsach_Load(object sender, EventArgs e)
        {
            loadDoituongchinhsach();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellValue(i, gridView1.Columns["Status"]).ToString() == "True")
                    {
                        PreferredDAO.PreferredIDList += gridView1.GetRowCellValue(i, gridView1.Columns["PreferredID"]).ToString() + ";";
                    }
                }
            }
            catch
            {


            }
            MessageBox.Show("" + PreferredDAO.PreferredIDList + "");
        }
    }
}