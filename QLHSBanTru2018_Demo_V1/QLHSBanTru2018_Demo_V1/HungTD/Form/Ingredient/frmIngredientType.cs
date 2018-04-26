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

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Ingredient
{
    public partial class frmIngredientType : DevExpress.XtraEditors.XtraUserControl
    {
        public frmIngredientType()
        {
            InitializeComponent();
        }

        private void frmIngredientType_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillGridControl();
        }
        private void FillGridControl()
        {
            gcMain.DataSource = new IngredientTypeDAO().ListAll();
            BindingDetail();
        }
        private void BindingDetail()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmIngredientTypeDetail frmITD = new frmIngredientTypeDetail();
            frmITD.setFunction(1);
            frmITD.ShowDialog();
            if(frmITD.DialogResult == DialogResult.OK){
                FillGridControl();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmIngredientTypeDetail frmITD = new frmIngredientTypeDetail();
            var rowHandle = gridView1.FocusedRowHandle;
            frmITD.setIngredientType(Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "IngredientTypeID").ToString()));
            frmITD.setFunction(2);
            frmITD.ShowDialog();
            if (frmITD.DialogResult == DialogResult.OK)
            {
                FillGridControl();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            if (MessageBox.Show("Bạn có muốn xóa loại thực phẩm \"" + gridView1.GetRowCellValue(rowHandle,"Name").ToString()+ "\"?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    new LessonDAO().Delete(Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "IngredientTypeID").ToString()));
                }
                catch
                {

                }
                finally
                {
                    FillGridControl();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
