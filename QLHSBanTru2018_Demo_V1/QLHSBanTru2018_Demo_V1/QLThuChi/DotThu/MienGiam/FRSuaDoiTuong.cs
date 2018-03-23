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

namespace QLHSBanTru2018_Demo_V1.QLThuChi.DotThu.MienGiam
{
    public partial class FRSuaDoiTuong : DevExpress.XtraEditors.XtraForm
    {
        public FRSuaDoiTuong()
        {
            InitializeComponent();
        }
        public void laoddataDoituong()
        {
            PreferredDAO dt = new PreferredDAO();
            grMiengiam.DataSource = dt.ListPreferred();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRSuaDoiTuong_Load(object sender, EventArgs e)
        {
            laoddataDoituong();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PreferredDAO dt = new PreferredDAO();
            for (int i = 0; i <gridView1.RowCount ; i++)
            {
                try
                {
                    Preferred a = new Preferred();
                    a.Name = gridView1.GetRowCellValue(i, gridView1.Columns["Name"]).ToString();
                    a.Status =bool.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["Status"]).ToString());
                    a.Percent = float.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["Percent"]).ToString());
                    dt.Insert(a);
                }
                catch 
                {

                    
                }
            }
        }
    }
}