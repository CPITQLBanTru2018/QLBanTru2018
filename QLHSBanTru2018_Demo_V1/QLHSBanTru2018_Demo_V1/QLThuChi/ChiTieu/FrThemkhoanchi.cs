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
using DataConnect.DAO.ThanhCongTC.ChiTieu;
using DataConnect;

namespace QLHSBanTru2018_Demo_V1.QLThuChi.ChiTieu
{
    public partial class FrThemkhoanchi : DevExpress.XtraEditors.XtraForm
    {
        public FrThemkhoanchi()
        {
            InitializeComponent();
        }
        #region hàm đi kèm
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
        public void LoadLoaiChi()
        {
            SpendSpeciesDAO dt = new SpendSpeciesDAO();
            cbbLoaichi.DataSource = dt.ListSpendSpecy();
            cbbLoaichi.ValueMember = "SpendSpeciesID";
            cbbLoaichi.DisplayMember = "Name";
        }
        public void loadChiTietHoaDon()
        {
            grChitiethoadon.DataSource = InvoiceDetailDAO.listDemoInvoiceDetail;
        }
        #endregion

        private void FrThemkhoanchi_Load(object sender, EventArgs e)
        {
            LoadNamhoc();
            LoadHocky();
            LoadLoaiChi();
            dtNgaykhoitao.EditValue = DateTime.Now;
            InvoiceDetailDAO.listDemoInvoiceDetail.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrChiTietHoaDon a = new FrChiTietHoaDon();
            a.ShowDialog();
            loadChiTietHoaDon();
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
                Tong += float.Parse(gridView1.GetRowCellValue(i, gridView1.Columns["TotalPriceDetail"]).ToString());
            }
            txtTongchi.Text = Tong.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceDAO dt = new InvoiceDAO();
                InvoiceDetailDAO dc = new InvoiceDetailDAO();
                Invoice a = new Invoice();
            }
            catch
            {

               
            }
        }
        private void cbbNamhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
             LoadHocky();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InvoiceDetailDAO.Therowfocust = e.FocusedRowHandle;
                InvoiceDetailDAO.DemoInvoiceDetail.NameInvoiceDetail = gridView1.GetRowCellValue(e.FocusedRowHandle, "NameInvoiceDetail").ToString();
                InvoiceDetailDAO.DemoInvoiceDetail.Price = (decimal)gridView1.GetRowCellValue(e.FocusedRowHandle, "Price");
                InvoiceDetailDAO.DemoInvoiceDetail.Unit = gridView1.GetRowCellValue(e.FocusedRowHandle, "Unit ").ToString();
                InvoiceDetailDAO.DemoInvoiceDetail.Amount = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "Amount ");
                InvoiceDetailDAO.DemoInvoiceDetail.TotalPriceDetail = (decimal)gridView1.GetRowCellValue(e.FocusedRowHandle, "TotalPriceDetail");
                InvoiceDetailDAO.DemoInvoiceDetail.Note = gridView1.GetRowCellValue(e.FocusedRowHandle, "Note").ToString();
                InvoiceDetailDAO.DemoInvoiceDetail.Status = (bool)gridView1.GetRowCellValue(e.FocusedRowHandle, "Status");
            }
            catch
            {

                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrSuaChiTietHoaDon a = new FrSuaChiTietHoaDon();
            a.ShowDialog();
        }
    }
}