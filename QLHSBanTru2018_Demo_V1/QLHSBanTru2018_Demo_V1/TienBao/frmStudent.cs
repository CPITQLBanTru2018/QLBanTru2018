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
using DataConnect.DAO.TienBao;
using DataConnect.DAO.HungTD;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace QLHSBanTru2018_Demo_V1.TienBao
{
    public partial class frmStudent : DevExpress.XtraEditors.XtraUserControl
    {
        #region System
        public frmStudent()
        {
            InitializeComponent();
        }
        #endregion


        #region LoadInfor
        private void LoadClassInfor(int GradeID)
        {
            List<DataConnect.Class> listClass = new ClassDAO().ListClassByGrade(GradeID);
            cmbLopHoc.DisplayMember= "Name";
            cmbLopHoc.ValueMember = "ClassID";
            cmbLopHoc.DataSource = listClass;
        }

        private void LoadGradeInfor(int SemesterID)
        {
            List<DataConnect.Grade> ListGrade = new DataConnect.DAO.HungTD.GradeDAO().ListBySemester(SemesterID);
            cmbKhoiLop.DisplayMember = "Name";
            cmbKhoiLop.ValueMember = "GradeID";
            cmbKhoiLop.DataSource = ListGrade;
        }

        private void LoadSemesterInfor(int CourseID)
        {
            List<DataConnect.Semester> ListSemester = new SemesterDAO().ListByCourseID(CourseID);
            cmbHocKy.DisplayMember = "Name";
            cmbHocKy.ValueMember = "SemesterID";
            cmbHocKy.DataSource = ListSemester;
        }

        private void LoadCourseInfor()
        {
            List<DataConnect.Course> ListCourse = new CourseDAO().ListAll();
            cmbNamHoc.DataSource = ListCourse;
            cmbNamHoc.DisplayMember = "Name";
            cmbNamHoc.ValueMember = "CourseID";
        }

        private void FillGridControl(int ClassID)
        {
            try
            {
                dgvHocSinh.DataSource = new StudentDAO().ListStudentByClass(ClassID);
                BindingDetail();
            }
            catch
            { }
        }

        private void FillStudentLock(int ClassID)
        {
            try
            {
                dgvHocSinh.DataSource = new StudentDAO().ListStudentLockByClass(ClassID);
                BindingDetail();
            }
            catch
            { }
        }

        private void BindingDetail()
        {
            txtStudentCode.DataBindings.Clear();
            txtStudentCode.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "StudentCode"));
            txtStudentID.DataBindings.Clear();
            txtStudentID.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "StudentID"));
            txtFirstName.DataBindings.Clear();
            txtFirstName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "FirstName"));
            txtLastName.DataBindings.Clear();
            txtLastName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "LastName"));
            dtBirthday.DataBindings.Clear();
            dtBirthday.DataBindings.Add(new Binding("EditValue", dgvHocSinh.DataSource, "Birthday", true, DataSourceUpdateMode.OnPropertyChanged));         
            radMale.DataBindings.Clear();
            radMale.DataBindings.Add(new Binding("Checked", dgvHocSinh.DataSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged));
                                   
            picImage.DataBindings.Clear();
            picImage.DataBindings.Add(new Binding("image", dgvHocSinh.DataSource, "Image", true, DataSourceUpdateMode.OnPropertyChanged));
            //txtAddress.DataBindings.Clear();
            //txtAddress.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "AdressDetail"));
            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "LocationDetail"));
            //radActive.DataBindings.Clear();
            //radActive.DataBindings.Add(new Binding("Checked", dgvHocSinh.DataSource, "Status", true, DataSourceUpdateMode.OnPropertyChanged));
            txtFatherName.DataBindings.Clear();
            txtFatherName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "FatherName"));
            txtFatherJob.DataBindings.Clear();
            txtFatherJob.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "FatherJob"));
            txtMotherName.DataBindings.Clear();
            txtMotherName.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "MotherName"));
            txtMotherJob.DataBindings.Clear();
            txtMotherJob.DataBindings.Add(new Binding("text", dgvHocSinh.DataSource, "MotherJob"));
            
        }

        void combobox_Defaule()
        {
            cmbNamHoc.Text = "-- Chọn năm học --";
            cmbHocKy.Text = "-- Chọn học kỳ --";
            cmbKhoiLop.Text = "-- Chọn khối lớp --";
            cmbLopHoc.Text = "-- Chọn lớp học --";
            cmbTrangThai.Text = "-- Đang học --";
        }

        void Enable_TextBox()
        {
            txtStudentCode.Enabled = false;
            txtStudentID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            dtBirthday.Enabled = false;
            txtAddress.Enabled = false;
            radMale.Enabled = false;
            radFemale.Enabled = false;
            //radActive.Enabled = false;
            //radLock.Enabled = false;
            txtFatherName.Enabled = false;
            txtFatherJob.Enabled = false;
            txtMotherName.Enabled = false;
            txtMotherJob.Enabled = false;
            //LabelStatus.Enabled = false;
            LabelGender.Enabled = false;
        }

        #endregion


        #region Event

        private void frmStudent_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            combobox_Defaule();
            Enable_TextBox();
            cmbNamHoc_SelectedIndexChanged(sender, e);
            cmbHocKy_SelectedIndexChanged(sender, e);
            cmbKhoiHoc_SelectedIndexChanged(sender, e);
            cmbLopHoc_SelectedIndexChanged(sender, e);

           

        }

        private void cmbNamHoc_Click(object sender, EventArgs e)
        {
            LoadCourseInfor();
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadSemesterInfor(int.Parse(cmbNamHoc.SelectedValue.ToString()));
            }
            catch
            {
            }
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadGradeInfor(int.Parse(cmbHocKy.SelectedValue.ToString()));

            }
            catch
            {
            }
        }

        private void cmbKhoiHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadClassInfor(int.Parse(cmbKhoiLop.SelectedValue.ToString()));

            }
            catch
            {
            }
        }

        private void cmbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrangThai.SelectedText == "-- Đang học --")
            {
                try
                {
                    FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
                }
                catch
                { }
            }
            else 
            {
                try
                {
                    FillStudentLock(int.Parse(cmbLopHoc.SelectedValue.ToString()));
                }
                catch
                { }
            }            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            combobox_Defaule();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmStudentDetail StudentDetail = new frmStudentDetail();
            StudentDetail.iFunction = 1;
            StudentDetail.ShowDialog();
            if (StudentDetail.DialogResult == DialogResult.OK);               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 2;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 3;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa học sinh ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                new StudentDAO().StudentDelete(int.Parse(txtStudentID.Text));
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            }
        }
        #endregion
   

        #region ========== ContextMenu ============
        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 3;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetail StudentDetail = new frmStudentDetail();
            StudentDetail.iFunction = 1;
            StudentDetail.ShowDialog();
            if (StudentDetail.DialogResult == DialogResult.OK) ;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetail m_StudentDetail = new frmStudentDetail();
            m_StudentDetail.iFunction = 2;
            m_StudentDetail.Student = new StudentDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.StudentParents = new StudentParentsDAO().GetByID(int.Parse(txtStudentID.Text));
            m_StudentDetail.Class = new ClassDAO().GetByClassID(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            m_StudentDetail.ShowDialog();
            if (m_StudentDetail.DialogResult == DialogResult.OK)
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa học sinh ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                new StudentDAO().StudentDelete(int.Parse(txtStudentID.Text));
                FillGridControl(int.Parse(cmbLopHoc.SelectedValue.ToString()));
            }
        }

        #endregion ========== ContextMenu ============


        #region ======== Export =========
        private void btnExport_Click(object sender, EventArgs e)
        {
            #region ============== Tạo đối tượng lưu tệp tin ==============
            //Excel.Range range = sheet.UsedRange;
            //        // doc
            //        int rows = range.Rows.Count;
            //        int cols = range.Columns.Count;
            
            #endregion ============== Tạo đối tượng lưu tệp tin ==============


            #region ============== Khởi tạo excel ==============
            // Khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Danh sách học sinh";
            app.Visible = true; // Cho hiển thị excel

            #endregion ============== Khởi tạo excel ==============

          
            #region ========== Đổ dữ liệu vào Sheet ==========           

            worksheet.Cells[1, 1] = "SỞ GIÁO DỤC VÀ ĐÀO TẠO HÀ NỘI ";
            worksheet.Cells[2, 1] = " TRƯỜNG MẦM NON HOA LINH ";
            worksheet.Cells[1, 6] = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM ";
            worksheet.Cells[2, 6] = "      Độc lập-Tự do-Hạnh phúc ";

            worksheet.Cells[4, 1] = "DANH SÁCH HỌC SINH LỚP: " + cmbLopHoc.Text;
            worksheet.Cells[5, 1] = "Năm học: " + cmbNamHoc.Text;

            worksheet.Cells[9, 1] = "STT";
            worksheet.Cells[9, 2] = "Mã học sinh";
            worksheet.Cells[9, 3] = "Họ và tên";
            worksheet.Cells[9, 4] = "Ngày sinh";
            worksheet.Cells[9, 5] = "Giới tính";
            worksheet.Cells[9, 6] = "Họ tên cha";
            worksheet.Cells[9, 7] = "Nghề nghiệp";
            worksheet.Cells[9, 8] = "Họ tên mẹ";
            worksheet.Cells[9, 9] = "Nghề nghiệp";

            // Duyệt hết các dòng trong datagridview

            for (int dong = 0; dong < bandedGridView1.RowCount; dong++)
            {
                for (int cot = 0; cot < bandedGridView1.Columns.Count; cot++)
                {
                    worksheet.Cells[dong + 10, 1] = dong + 1; // Số thứ tự
                   // worksheet.Cells[dong + 10, cot + 2]  = bandedGridView1.row[dong].Cells[cot].Value; // Values
                }
            }

            int dongData = bandedGridView1.RowCount;



                worksheet.Cells[dongData + 13, 7] = "Hà Nội, ngày          tháng           năm            . ";
                worksheet.Cells[dongData + 14, 7] = " HIỆU TRƯỞNG. ";

            #endregion ========== Đổ dữ liệu vào Sheet ==========


            #region ============= Căn chỉnh excel =============
            // Đinh dạng trang

            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait; // Giấy dọc
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4; // Loại giấy A4
            worksheet.PageSetup.LeftMargin = 0; // Căn lề trái
            worksheet.PageSetup.TopMargin = 0; // Căn lề trên
            worksheet.PageSetup.RightMargin = 0; // Căn lề phải
            worksheet.PageSetup.BottomMargin = 0; // Căn lề dưới

            //    worksheet.PageSetup.CenterHorizontally = true; // Căn giữa theo chiều ngang

            // Định dạng cột
            worksheet.Range["A1"].ColumnWidth = 10;
            worksheet.Range["B1"].ColumnWidth = 10;
            worksheet.Range["C1"].ColumnWidth = 30;
            worksheet.Range["D1"].ColumnWidth = 12;
            worksheet.Range["E1"].ColumnWidth = 15;
            worksheet.Range["F1"].ColumnWidth = 15;
            worksheet.Range["G1"].ColumnWidth = 20;
            worksheet.Range["H1"].ColumnWidth = 20;

            // Định dạng font chữ

            worksheet.Range["A1", "H100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "H100"].Font.Size = 12; // size cho font chữ
            worksheet.Range["A4", "H4"].Font.Size = 14; // Size tiêu đề lớn hơn chút
            worksheet.Range["A5", "H5"].Font.Size = 14;
            worksheet.Range["A1", "H1"].Font.Size = 14;
            worksheet.Range["A2", "H2"].Font.Size = 14;

            worksheet.Range["A4", "H4"].MergeCells = true; // Nhập dòng tiêu đề
            worksheet.Range["A5", "H5"].MergeCells = true;
            worksheet.Range["A1", "C1"].MergeCells = true;
            worksheet.Range["A2", "C2"].MergeCells = true;
            worksheet.Range["E1", "G1"].MergeCells = true;
            worksheet.Range["E2", "G2"].MergeCells = true;

            worksheet.Range["A4", "H4"].Font.Bold = true; // Tô đậm tiêu đề
            worksheet.Range["A5", "H5"].Font.Bold = true;
            worksheet.Range["A2", "H2"].Font.Bold = true;
            worksheet.Range["A9", "G9"].Font.Bold = true; // Tô đậm tên cột trong bảng
            worksheet.Range["G" + (dongData + 13), "H" + (dongData + 13)].Font.Italic = true; //in nghiêng ngày tháng năm
            worksheet.Range["G" + (dongData + 14), "H" + (dongData + 14)].Font.Bold = true; // Tô đậm tên cột trong bảng

            //    // Kẻ bảng điểm

            //    worksheet.Range["A9", "H" + (dongData + 9)].Borders.LineStyle = 1;

            //    // Định dạng các cột các dòng text
            //    worksheet.Range["A1", "A9"].HorizontalAlignment = 3; // Căn giữa tiêu đề bảng
            //    worksheet.Range["A9", "H9"].HorizontalAlignment = 3; // Tiêu đề cột bảng căn giữa
            //    worksheet.Range["A4", "H4"].HorizontalAlignment = 3;
            //    worksheet.Range["A5", "H5"].HorizontalAlignment = 3;

            //    worksheet.Range["A10", "A" + (dongData + 12)].HorizontalAlignment = 3; // 
            //    worksheet.Range["D10", "D" + (dongData + 12)].HorizontalAlignment = 3; //
            //    worksheet.Range["E10", "E" + (dongData + 12)].HorizontalAlignment = 3; // 
            //    worksheet.Range["F10", "F" + (dongData + 12)].HorizontalAlignment = 3; // 
            //                                                                           // worksheet.Range["G10", "G" + (dongData + 8)].HorizontalAlignment = 3; // 
            //                                                                           // worksheet.Range["H10", "H" + (dongData + 8)].HorizontalAlignment = 3; //

            #endregion ============= Căn chỉnh excel =============

        }
        #endregion ======== Export =========
    }
}
