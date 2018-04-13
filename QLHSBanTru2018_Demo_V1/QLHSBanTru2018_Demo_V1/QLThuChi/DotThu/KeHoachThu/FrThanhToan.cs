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
using DataConnect;

namespace QLHSBanTru2018_Demo_V1.QLThuChi.DotThu.KeHoachThu
{
    public partial class FrThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public FrThanhToan()
        {
            InitializeComponent();
        }
        public void LoadKhoaPhi()
        {
            ReceivableDetail_StudentDAO dt = new ReceivableDetail_StudentDAO();
            ReceivableDetailDAO dc = new ReceivableDetailDAO();
            List<ReceivableDetail_Student> a = new List<ReceivableDetail_Student>();
            List<ReceivableDetail> b = new List<ReceivableDetail>();
            a = dt.ListReceivableDetail_Student(ClassStudentDAO.StudentID);
            foreach (var i in a)
            {
                ReceivableDetail c = new ReceivableDetail();
                c = dc.ReceivableDetaiByStudenID(i.ReceivableDetailID, ReceivableIDAO.ReceivableID);
                if (c!=null)
                {
                    b.Add(c);
                }
                
            }
            grDanhsachkhoanthu.DataSource = b;
        }
        public void checkKhoathu()
        {
            ReceivableDetail_StudentDAO dt = new ReceivableDetail_StudentDAO();
            List<ReceivableDetail_Student> a = new List<ReceivableDetail_Student>();
            a = dt.ListReceivableDetail_Student(ClassStudentDAO.StudentID);
            foreach (var i in a)
            {
                //bool b = (bool)i.Status;
                for (int j = 0; j < gridView1.RowCount; j++)
                {
                    if ((int)gridView1.GetRowCellValue(j, gridView1.Columns["ReceivableDetailID"])==(int)i.ReceivableDetailID)
                    {
                        gridView1.SetRowCellValue(j, "Status", (bool)i.Status);
                    }
                }
            }
        }
        public void loatGrKhoanPhi()
        {
            decimal a = 0;
            decimal b=0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, gridView1.Columns["Status"]).ToString() == "True")
                {
                    a += (decimal)gridView1.GetRowCellValue(i, gridView1.Columns["TotalPriceDetail"]);
                }
                b+= (decimal)gridView1.GetRowCellValue(i, gridView1.Columns["TotalPriceDetail"]);
            }
            txtDathanhtoan.Text = a.ToString();
            txtTongSo.Text = b.ToString();
            txtConlai.Text = (b - a).ToString();          
        }
        private void FrThanhToan_Load(object sender, EventArgs e)
        {
            LoadKhoaPhi();           
            checkKhoathu();
            loatGrKhoanPhi();
        }
        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {           
            string b = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["Status"]).ToString();
            if (b=="True")
            {
                gridView1.SetRowCellValue(e.RowHandle, "Status", false);
            }
            else
            {
                gridView1.SetRowCellValue(e.RowHandle, "Status", true);
            }
            if ((bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns["Status"])==true)
            {
                txtDathanhtoan.Text = (decimal.Parse(txtDathanhtoan.Text) + (decimal)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TotalPriceDetail"])).ToString();
            }
            else
            {
                txtDathanhtoan.Text = (decimal.Parse(txtDathanhtoan.Text) - (decimal)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TotalPriceDetail"])).ToString();
            }
          
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ReceivableDetail_StudentDAO dt = new ReceivableDetail_StudentDAO();
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    ReceivableDetail_Student a = new ReceivableDetail_Student();
                    a.ReceivableDetailID = (int)gridView1.GetRowCellValue(i, gridView1.Columns["ReceivableDetailID"]);
                    a.StudentID = ClassStudentDAO.StudentID;
                    a.Status = (bool)gridView1.GetRowCellValue(i, gridView1.Columns["Status"]);
                    if (dt.Edit(a)==true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Bản ghi thứ " + i + " Chưa được lưu");
                    }
                    
                }
                MessageBox.Show("Lưu thành công");
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Lỗi");
                
            }
        }
    }
}