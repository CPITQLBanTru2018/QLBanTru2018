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

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Dish
{
    public partial class frmDish : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDish()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDishDetail frmDD = new frmDishDetail();
            //var rowHandle = view.FocusedRowHandle;
            //try
            //{
            //    frmTLD.setLesson(lessonID = Convert.ToInt32(view.GetRowCellValue(rowHandle, "LessonID").ToString()));
            //}
            //catch
            //{
            //    var rowChild = view.GetChildRowHandle(rowHandle, 0);
            //    frmTLD.setLesson(lessonID = Convert.ToInt32(view.GetRowCellValue(rowChild, "LessonID").ToString()));
            //}
            frmDD.setFunction(1);
            //frmDD.setTitle("Thêm Mới Món Ăn");
            frmDD.ShowDialog();
            //if (frmDD.DialogResult == DialogResult.OK)
            //    FillCombobox();
        }
    }
}
