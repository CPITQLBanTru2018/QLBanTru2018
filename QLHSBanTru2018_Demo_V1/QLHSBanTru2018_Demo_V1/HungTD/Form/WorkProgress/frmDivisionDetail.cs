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
using DataConnect.DAO.HungTD;

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.WorkProgress
{
    public partial class frmDivisionDetail : DevExpress.XtraEditors.XtraForm
    {
        public int iFunction;
        public DataConnect.Employee employee;
        public Division division;
        public void setFunction(int function)
        {
            this.iFunction = function;
        }
        public void setEmployee(int employeeID)
        {
            this.employee = new EmployeeDAO().GetByID(employeeID);
        }
        public frmDivisionDetail()
        {
            InitializeComponent();
        }

        private void frmDivisionDetail_Load(object sender, EventArgs e)
        {
            FillDepartment();
            FillLocation();
            FillDate();
            LoadDetail();
        }
        private void LoadDetail()
        {
            if (iFunction == 2 && division != null)
            {
                cbbDepartment.SelectedItem = division.DepartmentID;
                cbbPosition.SelectedItem = division.PositionID;
                dtStartDate.EditValue = division.StartDate;
                dtEndDate.EditValue = division.EndDate;
                dtCreatedDate.EditValue = division.CreatedDate;
                txtNote.Text = division.Note;
                chkActive.Checked = division.Status;
            }
        }
        private void FillDepartment()
        {
            cbbDepartment.DataSource = new DepartmentDAO().ListAll();
            cbbDepartment.ValueMember = "DepartmentID";
            cbbDepartment.DisplayMember = "Name";
        }
        private void FillLocation()
        {
            cbbPosition.DataSource = new PositionDAO().ListAll();
            cbbPosition.ValueMember = "PositionID";
            cbbPosition.DisplayMember = "Name";
        }
        private void FillDate()
        {
            dtStartDate.EditValue = DateTime.Now;
            dtEndDate.EditValue = DateTime.Now;
            dtCreatedDate.EditValue = DateTime.Now;
        }
    }
}