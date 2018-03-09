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

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Course
{
    public partial class frmCourseDetail : DevExpress.XtraEditors.XtraForm
    {
        public int Function = 0;
        public DataConnect.Course course;
        public frmCourseDetail()
        {
            InitializeComponent();
        }

        private void frmCourseDetail_Load(object sender, EventArgs e)
        {
            if (Function == 2)
            {
                try
                {
                    txtName.Text = course.Name;
                    dtStartDate.EditValue = course.StartDate;
                    dtEndDate.EditValue = course.EndDate;
                    chbStatus.Checked = course.Status == true ? true : false;
                }
                catch
                {

                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataConnect.Course entity = new DataConnect.Course();
            entity.Name = txtName.Text;
            entity.StartDate = DateTime.Parse(dtStartDate.EditValue.ToString());
            entity.EndDate = DateTime.Parse(dtEndDate.EditValue.ToString());
            entity.Status = chbStatus.Checked == true ? true : false;
            if (Function == 1)
            {
                if (new CourseDAO().Insert(entity) == true)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else if (Function == 2)
            {
                entity.CourseID = course.CourseID;
                if (new CourseDAO().Edit(entity) == true)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {

                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}