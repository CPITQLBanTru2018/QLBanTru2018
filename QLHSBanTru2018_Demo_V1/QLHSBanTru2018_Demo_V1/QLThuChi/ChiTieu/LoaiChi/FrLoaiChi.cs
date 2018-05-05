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
using QLHSBanTru2018_Demo_V1.QLThuChi.ChiTieu.LoaiChi;
using DataConnect.DAO.ThanhCongTC.ChiTieu;

namespace QLHSBanTru2018_Demo_V1.QLThuChi.ChiTieu
{
    public partial class FrLoaiChi : DevExpress.XtraEditors.XtraForm
    {
        public FrLoaiChi()
        {
            InitializeComponent();
        }
        #region hàm-------
        public void laodCacloaichi()
        {
            try
            {
                SpendSpeciesDAO dt = new SpendSpeciesDAO();
                grCacLoaiChi.DataSource = dt.ListSpendSpecy();
            }
            catch 
            {

               
            }
        }
        #endregion
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrThemLoaiChi a = new FrThemLoaiChi();
            a.ShowDialog();
        }

        private void FrLoaiChi_Load(object sender, EventArgs e)
        {
            laodCacloaichi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                SpendSpeciesDAO.spend.SpendSpeciesID = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "SpendSpeciesID");
                //SpendSpeciesDAO.spend.Name = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "SpendSpeciesID").ToString();
                //SpendSpeciesDAO.spend.CreatedDate = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "SpendSpeciesID");
                //SpendSpeciesDAO.spend.Note = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "SpendSpeciesID");
                //SpendSpeciesDAO.spend.Status = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "SpendSpeciesID");
            }
            catch 
            {

                
            }
        }
    }
}