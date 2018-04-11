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
            FillGridControls();
        }
        private void FillGridControls()
        {
            gcTopicLesson.DataSource = new LessonDAO().FilterByTopicType(1);
            
            BindingDetail();
        }
        private void BindingDetail()
        {

        }
    }
}
