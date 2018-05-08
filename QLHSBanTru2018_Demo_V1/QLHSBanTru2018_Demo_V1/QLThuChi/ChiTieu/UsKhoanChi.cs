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
using DataConnect.DAO.ThanhCongTC.ChiTieu;

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
            cbbHocky.DataSource = dt.ListSemesterByID((int)cbbNamhoc.SelectedValue);
            cbbHocky.ValueMember = "SemesterID";
            cbbHocky.DisplayMember = "Name";
        }
        public void LoadHoaDon()
        {
            try
            {
                InvoiceDAO dt = new InvoiceDAO();
                grKhoanchi.DataSource = dt.ListInvoice((int)cbbNamhoc.SelectedValue, (int)cbbHocky.SelectedValue);
            }
            catch 
            {

               
            }
        }
        public void LoadChiTietHoaDon()
        {
            InvoiceDetailDAO dt = new InvoiceDetailDAO();
            grChitietkhoanchi.DataSource = dt.ListInvoiceDetail(System.Guid.Parse(txtMaHoaDon.Text));
        }

        private void UsKhoanChi_Load(object sender, EventArgs e)
        {
            LoadNamhoc();
            LoadHocky();
            LoadHoaDon();
            LoadChiTietHoaDon();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            FrThemkhoanchi a = new FrThemkhoanchi();
            a.ShowDialog();
            LoadHoaDon();
        }

        private void cbbNamhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadHocky();
            LoadHoaDon();
            LoadChiTietHoaDon();
        }

        private void cbbHocky_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadChiTietHoaDon();
        }

        private void bntXuathoadon_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                //load thong tin hóa đơn
                txtMaHoaDon.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "InvoiceID").ToString();
                dtNgayTao.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "CreatedDate");
                txtTongTien.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "TotalPrice").ToString();
                txtHoTen.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "NameMoneyReceive").ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "AdressDetail").ToString();
                txtSDT.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "PhoneNumber").ToString();
                txtGhichu.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "Note").ToString();
                //laod chi tiết hóa đơn
                LoadChiTietHoaDon();
            }
            catch 
            {

                
            }
        }
    }
}
