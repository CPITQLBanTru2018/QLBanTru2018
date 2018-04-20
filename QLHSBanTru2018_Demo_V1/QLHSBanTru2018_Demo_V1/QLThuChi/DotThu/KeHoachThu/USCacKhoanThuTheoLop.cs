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
using System.IO;
using DataConnect;
using QLHSBanTru2018_Demo_V1.QLThuChi.DotThu.KeHoachThu;
using DevExpress.XtraSplashScreen;

namespace QLHSBanTru2018_Demo_V1.QLThuChi
{
    public partial class USCacKhoanThuTheoLop : DevExpress.XtraEditors.XtraUserControl
    {
        public USCacKhoanThuTheoLop()
        {
            InitializeComponent();
        }
        #region ----------------danhsach---------------
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
            cbbHocky.DataSource = dt.ListSemester();
            cbbHocky.ValueMember = "SemesterID";
            cbbHocky.DisplayMember = "Name";
        }
        public void LoadKhoihoc()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            cbbKhoihoc.DataSource = dt.ListGrade();
            cbbKhoihoc.ValueMember = "GradeID";
            cbbKhoihoc.DisplayMember = "Name";
        }
        public void LoadLophoc()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            //grDanhSachLopHoc.DataSource = dt.ListClass();
            cbbLophoc.DataSource = dt.ListClass();
            cbbLophoc.ValueMember = "ClassID";
            cbbLophoc.DisplayMember = "Name";
        }
        public void laodDotthu()
        {
            ReceivableIDAO dt = new ReceivableIDAO();
            cbbDotthu.DataSource = dt.ListReceivable();
            cbbDotthu.ValueMember = "ReceivableID";
            cbbDotthu.DisplayMember = "Name";
        }

        private void USCacKhoanThuTheoLop_Load(object sender, EventArgs e)
        {
            try
            {
                laodDotthu();
                LoadNamhoc();
                studentReceivableDAO.CourseID = (int)cbbNamhoc.SelectedValue;
                LoadHocky();
                studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
                LoadKhoihoc();
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                //loadDSHS();
            }
            catch 
            {

               
            }
        }
        public void LoadDSLop()
        {
            studentReceivableDAO dt = new studentReceivableDAO();
            grDanhSachHocSinh.DataSource = dt.ListStudents();
        }

        private void cbbNamhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                studentReceivableDAO.CourseID = (int)cbbNamhoc.SelectedValue;
                LoadHocky();
                studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
                LoadKhoihoc();
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                loadDSHS();
            }
            catch 
            {

                
            }
        }

        private void cbbHocky_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                studentReceivableDAO.SemesterID = (int)cbbHocky.SelectedValue;
                LoadKhoihoc();
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                loadDSHS();
            }
            catch 
            {

                
            }
        }

        private void cbbKhoihoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                studentReceivableDAO.GradeID = (int)cbbKhoihoc.SelectedValue;
                LoadLophoc();
                loadDSHS();
            }
            catch 
            {

                
            }
        }
        public void loadDSHS()
        {
            ClassStudentDAO dt = new ClassStudentDAO();
            grDanhSachHocSinh.DataSource = dt.ListStudent((int)cbbLophoc.SelectedValue);
        }
        private void cbbLophoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //studentReceivableDAO.ClassID = (int)cbbDotthu.SelectedValue;
            loadDSHS();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                ClassStudentDAO dt = new ClassStudentDAO();
                ClassStudentDAO.StudentID = (int)gridView1.GetRowCellValue(e.FocusedRowHandle, "StudentID");
                Student a = dt.lookForStuden(ClassStudentDAO.StudentID);
                txtTenhocsinh.Text = a.FirstName + " " + a.LastName;
                txtNgaySinh.Text = a.Birthday.ToString();
                txtDiachi.Text = a.AdressDetail;
                MemoryStream mom = new MemoryStream(a.Image.ToArray());
                Image b = Image.FromStream(mom);
                pcAnhhocsinh.Image = b;
            }
            catch 
            {

                
            }
        }

        private void cbbDotthu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ReceivableIDAO.ReceivableID = (int)cbbDotthu.SelectedValue;
        }

        private void bntThanhToan_Click(object sender, EventArgs e)
        {
            FrThanhToan a = new FrThanhToan();
            a.ShowDialog();
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            ReceivableDetail_StudentDAO dt = new ReceivableDetail_StudentDAO();
            ReceivableDetailDAO dc = new ReceivableDetailDAO();
            List<ReceivableDetail_Student> a = new List<ReceivableDetail_Student>();
            List<ReceivableDetail> b = new List<ReceivableDetail>();
            List<ReceivableDetail_Student> f = new List<ReceivableDetail_Student>();
            int rowindex = e.ListSourceRowIndex;
            a = dt.ListReceivableDetail_Student((int)gridView1.GetListSourceRowCellValue(rowindex, "StudentID"));
            b = dc.ListReceivableDetail((int)cbbDotthu.SelectedValue);
            foreach (var i in b)
            {
                foreach (var j in a)
                {
                    if (i.ReceivableDetailID==j.ReceivableDetailID)
                    {
                        f.Add(j);
                    }
                }
            }
            if (e.Column.FieldName != "tinhtrang") return;
            foreach (var i in f)
            {
                //MessageBox.Show("" + i.ReceivableDetailID + " " + i.StudentID + " " + i.Status + "");
                if (i.Status==false)
                {
                    e.Value = "Chưa hàn thành";
                    break;
                }
                e.Value = "Đã hoàn thành";
            }
        }
        #endregion danhsach
        #region =======excell============
        private void export()
        {
            
             #region===========khởi tạo excel=====
            //khởi tạo excell
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //khởi tạo workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //khởi tọa worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Danh sách hoc sinh";
            app.Visible = true;//cho hiển thị excel
            #endregion===========khởi tạo excel==========
            #region ===========đổ dữ liệu vào sheet======
            worksheet.Cells[1, 1] = "SỞ GIÁO DỤC VÀ ĐÀO TẠO HÀ NỘI";
            worksheet.Cells[2, 1] = "TRƯỜNG MẦM NON HOA LINH";


            worksheet.Cells[4, 1] = "DANH SÁCH HỌC SINH";
            worksheet.Cells[5, 1] = "Năm học:" + cbbNamhoc.Text;
            worksheet.Cells[6, 1] = "Khối:" + cbbKhoihoc.Text;
            worksheet.Cells[7, 1] = "Lớp:" + cbbLophoc.Text;

            worksheet.Cells[9, 1] = "STT";
            worksheet.Cells[9, 2] = "Mã học sinh";
            worksheet.Cells[9, 3] = "Họ";
            worksheet.Cells[9, 4] = "Tên";
            worksheet.Cells[9, 5] = "Ngày sinh";
            worksheet.Cells[9, 6] = "Giới tính";
            worksheet.Cells[9, 7] = "Địa chỉ";
            worksheet.Cells[9, 8] = "Tình trạng";

            //duyệt dết các dòng trong trong gridcontrol
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                worksheet.Cells[10 + i, 1] = i + 1;
                worksheet.Cells[10 + i, 2] = gridView1.GetRowCellValue(i, gridView1.Columns["StudentCode"]);
                worksheet.Cells[10 + i, 3] = gridView1.GetRowCellValue(i, gridView1.Columns["FirstName"]);
                worksheet.Cells[10 + i, 4] = gridView1.GetRowCellValue(i, gridView1.Columns["LastName"]);
                worksheet.Cells[10 + i, 5] = gridView1.GetRowCellValue(i, gridView1.Columns["Birthday"]);
                if ((bool)gridView1.GetRowCellValue(i,gridView1.Columns["Gender"])==true)
                {
                    worksheet.Cells[10 + i, 6] = "Nam";
                }
                else
                {
                    worksheet.Cells[10 + i, 6] = "Nữ";
                }
                //worksheet.Cells[10 + i, 6] = gridView1.GetRowCellValue(i, gridView1.Columns["Gender"]);
                worksheet.Cells[10 + i, 7] = gridView1.GetRowCellValue(i, gridView1.Columns["AdressDetail"]);
                worksheet.Cells[10 + i, 8] = gridView1.GetRowCellValue(i, gridView1.Columns["tinhtrang"]);
            }
            int dongData = gridView1.RowCount;
            worksheet.Cells[dongData + 13, 9] = "Hà Nội, ngày          tháng           năm            . ";
            worksheet.Cells[dongData + 14, 9] = "HIỆU TRƯỞNG. ";
            #endregion============đổ dữ liệu vào sheet=======
            #region=====căn chỉnh======
            //định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait; // Giấy dọc
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4; // Loại giấy A4
            worksheet.PageSetup.LeftMargin = 0;//can le trai
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
            worksheet.PageSetup.CenterHorizontally = true;//can giua theo chieu ngang
            //dinh dang cot
            worksheet.Range["A1"].ColumnWidth = 3;
            worksheet.Range["B1"].ColumnWidth = 13;
            worksheet.Range["C1"].ColumnWidth = 13;
            worksheet.Range["D1"].ColumnWidth = 8;
            worksheet.Range["E1"].ColumnWidth = 13;
            worksheet.Range["F1"].ColumnWidth = 10;
            worksheet.Range["G1"].ColumnWidth = 28;
            worksheet.Range["H1"].ColumnWidth = 14;
            worksheet.Range["I1"].ColumnWidth = 11;
            worksheet.Range["J1"].ColumnWidth = 14;
            worksheet.Range["K1"].ColumnWidth = 11;
            //dinh dang font chu
            worksheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "K100"].Font.Size = 10; // size cho font chữ
            worksheet.Range["A4", "K4"].Font.Size = 12; // Size tiêu đề lớn hơn chút
            worksheet.Range["A1", "K2"].Font.Size = 16; // Size tiêu đề lớn hơn chút
            worksheet.Range["A5", "K7"].Font.Size = 12;

            worksheet.Range["A1", "C1"].MergeCells = true; // Nhập dòng tiêu đề
            #endregion====căn chỉnh=====
        }

        #endregion======excell===========

        private void bntXuatdanhsach_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(SplashScreen1));
            export();
            SplashScreenManager.CloseForm();
        }

       
    }
}
