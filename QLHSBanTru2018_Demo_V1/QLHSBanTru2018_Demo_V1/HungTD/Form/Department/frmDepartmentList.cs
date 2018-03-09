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
using DataConnect.DAO.HungTD;
using DataConnect;
using DataConnect.ViewModel;

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Department
{
    public partial class frmDepartmentList : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDepartmentList()
        {
            InitializeComponent();
        }

        private void frmDepartmentList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillGridControl();
            testLoadEmployee();
        }
        #region Đổ dữ liệu vào GridControl
        private void FillGridControl()
        {
            gcDepartmentList.DataSource = new DepartmentDAO().ListAll();
            BindingDetail();
        }

        #endregion
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDepartmentDetail departmentDetail = new frmDepartmentDetail();
            departmentDetail.Function = 1;
            departmentDetail.ShowDialog();
            if (departmentDetail.DialogResult == DialogResult.OK)
                FillGridControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmDepartmentDetail departmentDetail = new frmDepartmentDetail();
            departmentDetail.Function = 2;
            departmentDetail.department = new DepartmentDAO().GetByID(int.Parse(txtDepartmentID.Text));
            departmentDetail.ShowDialog();
            if (departmentDetail.DialogResult == DialogResult.OK)
                FillGridControl();
        }
        private void testLoadEmployee()
        {
            List<Department_EmployeeViewModel> listEmployee;
            try
            {
                listEmployee = new EmployeeDAO().ListAllByDepartment(int.Parse(txtDepartmentID.Text));
                gcEmployee.DataSource = listEmployee;
            }
            catch
            {

            }
        }
        private void BindingDetail()
        {
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add(new Binding("text", gcDepartmentList.DataSource, "Name"));
            txtDepartmentID.DataBindings.Clear();
            txtDepartmentID.DataBindings.Add(new Binding("text",gcDepartmentList.DataSource,"DepartmentID"));
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            testLoadEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa "+txtName.Text,"Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (new DepartmentDAO().Delete(int.Parse(txtDepartmentID.Text)) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xin lỗi, đã xảy ra lỗi!", "Thông báo");
                }
                FillGridControl();
            }
        }
    }
}
