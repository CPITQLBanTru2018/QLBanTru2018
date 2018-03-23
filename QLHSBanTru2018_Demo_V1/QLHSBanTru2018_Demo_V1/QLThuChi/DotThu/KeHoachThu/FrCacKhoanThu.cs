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
    public partial class FrThietLapKeHoachThu : DevExpress.XtraEditors.XtraForm
    {
        public FrThietLapKeHoachThu()
        {
            InitializeComponent();
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadDataKeHoachThu()
        {
            grCacKhoanThu.DataSource = ReceivableDetailDAO.ListDemoReceivableDetail;
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            
            FTaoKhoanThu a = new FTaoKhoanThu();
            a.ShowDialog();
            //LoadDataKeHoachThu();
            grCacKhoanThu.DataSource = ReceivableDetailDAO.ListDemoReceivableDetail;

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.WindowState = FormWindowState.Normal;
                }

            }
            float Tong = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                Tong += float.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["Price"]).ToString());
            }
            txtTongtien.Text = Tong.ToString()+"đ";

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            FRSuaKhoanThu a = new FRSuaKhoanThu();
            a.ShowDialog();
        }

        private void FrThietLapKeHoachThu_Load(object sender, EventArgs e)
        {

        }

        private void bntKhoitao_Click(object sender, EventArgs e)
        {
            try
            {
                string a = txtTongtien.Text;
                a = a.Trim();
                a = a.Substring(0, a.LastIndexOf("đ"));
                ReceivableIDAO rb = new ReceivableIDAO();
                ReceivableDetailDAO rbd = new ReceivableDetailDAO();
                Receivable rbdt = new Receivable();
                rbdt.Name = txtTendotthu.Text;
                rbdt.TotalPrice = decimal.Parse(a);
                rbdt.StartDate = dtNgaybatdau.Value;
                rbdt.EndDate = dtNgayketthuc.Value;
                rbdt.CreatedDate = dtNgaykhoitao.Value;
                rbdt.Status = false;
                int c = rb.Insert(rbdt);
                if (c != 0)
                {
                    ReceivableDetail detail = new ReceivableDetail();
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        detail.Name = gridView1.GetRowCellValue(i, gridView1.Columns["Name"]).ToString();
                        detail.ReceivableID = c;
                        detail.Price = decimal.Parse(a);
                        detail.Status = false;
                        int d = rbd.Insert(detail);
                        if (d != 0)
                        {
                           

                        }
                        else
                        {
                            MessageBox.Show("Ban ghi " + i + " bi loi");
                        }
                    }
                    MessageBox.Show("Khoi tao hoan tat");
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Loi");
                
            }
        }

        private void bntDoituongchinhsach_Click(object sender, EventArgs e)
        {
            FRDienMienGiam a = new FRDienMienGiam();
            a.ShowDialog();
        }
    }
}