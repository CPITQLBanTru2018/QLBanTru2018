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
using DataConnect.ViewModel;

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.TopicLession
{
    public partial class frmTopicLesson : DevExpress.XtraEditors.XtraUserControl
    {
        public frmTopicLesson()
        {
            InitializeComponent();
        }

        private void frmTopicLesson_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillCombobox();
        }
        private void FillGridControls(int topicTypeID)
        {
            gcTopicLesson.DataSource = new LessonDAO().FilterByTopicType(topicTypeID);            
            BindingDetail();
        }
        private void BindingDetail()
        {
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add(new Binding("Text", gcTopicLesson.DataSource, "Name"));
            txtDescription.DataBindings.Clear();
            txtDescription.DataBindings.Add(new Binding("Text", gcTopicLesson.DataSource, "Description"));
            txtLessonID.DataBindings.Clear();
            txtLessonID.DataBindings.Add(new Binding("Text", gcTopicLesson.DataSource, "LessonID"));
        }
        private void FillCombobox()
        {
            cbbTopicType.Items.Clear();
            cbbTopicType.DataSource = new TopicTypeDAO().ListAll();
            cbbTopicType.DisplayMember = "Name";
            cbbTopicType.ValueMember = "TopicTypeID";
        }

        private void cbbTopicType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillGridControls(int.Parse(cbbTopicType.SelectedValue.ToString()));
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
