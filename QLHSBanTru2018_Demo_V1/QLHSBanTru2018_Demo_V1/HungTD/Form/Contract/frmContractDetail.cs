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
using DataConnect.DAO.HungTD;

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Contract
{
    public partial class frmContractDetail : DevExpress.XtraEditors.XtraForm
    {
        public frmContractDetail()
        {
            InitializeComponent();
        }

        private void frmContractDetail_Load(object sender, EventArgs e)
        {            
            FillGridControl();
            Prepared();
        }
        private void FillGridControl()
        {
            gcListEmployee.DataSource = new EmployeeDAO().ListAllEmployee(null, null, null);
            BindingDetail();
        }
        private void Prepared()
        {
            cbbTimeType.SelectedIndex = 0;
            dtStartDate.EditValue = DateTime.Now;
            dtEndDate.Enabled = true;
            dtEndDate.EditValue = DateTime.Now;
            dtCreatedDate.EditValue = DateTime.Now;

            cbbCreatedBy.DataSource = new EmployeeDAO().LoadLeader();
            cbbCreatedBy.DisplayMember = "LastName";
            cbbCreatedBy.ValueMember = "EmployeeID";
        }
        private void BindingDetail()
        {
            txtFullName.DataBindings.Clear();
            txtFullName.DataBindings.Add(new Binding("Text", gcListEmployee.DataSource, "FullName"));
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add(new Binding("Text", gcListEmployee.DataSource, "Username"));
            dtBirthday.DataBindings.Clear();
            dtBirthday.DataBindings.Add(new Binding("EditValue", gcListEmployee.DataSource, "Birthday"));
            txtIdentityNumber.DataBindings.Clear();
            txtIdentityNumber.DataBindings.Add(new Binding("Text", gcListEmployee.DataSource, "IdentityNumber"));
            dtDateOfIssue.DataBindings.Clear();
            dtDateOfIssue.DataBindings.Add(new Binding("EditValue", gcListEmployee.DataSource, "DateOfIssue"));
            txtPlaceOfIssue.DataBindings.Clear();
            txtPlaceOfIssue.DataBindings.Add(new Binding("Text",gcListEmployee.DataSource, "PlaceOfIssue"));
            picImage.DataBindings.Clear();
            picImage.DataBindings.Add(new Binding("image", gcListEmployee.DataSource, "Image", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void cbbTimeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimeType.SelectedIndex == 0)
            {
                dtEndDate.Enabled = true;
            }
            else
            {
                dtEndDate.Enabled = false;
            }
        }
    }
}