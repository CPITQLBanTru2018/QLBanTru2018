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

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Ingredient
{
    public partial class frmUpdateQuantity : DevExpress.XtraEditors.XtraForm
    {
        public int iFunction = 0;
        public DataConnect.Ingredient ingredient;
        public void setFunction(int function)
        {
            this.iFunction = function;
        }
        public void setTitle(string title)
        {
            this.Text = title;
        }
        public void setIngredient(int ingredientID)
        {
            this.ingredient = new IngredientDAO().GetByID(ingredientID);
        }
        public frmUpdateQuantity()
        {
            InitializeComponent();
        }
        private void frmUpdateQuantity_Load(object sender, EventArgs e)
        {
            LoadDetail();
        }
        private void LoadDetail()
        {
            txtBefor.Text = ingredient.QuantityOfUnit.ToString();
            txtAfter.Text = ingredient.QuantityOfUnit.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "")
            {
                try
                {
                    if (new IngredientDAO().UpdateQuantity(ingredient.IngredientID, float.Parse(txtValue.Text.ToString()), iFunction))
                    {
                        if (iFunction == 1)
                        {
                            MessageBox.Show("Nhập nguyên liệu thành công!", "Thành công!");
                        }
                        else if (iFunction == 2)
                        {
                            MessageBox.Show("Xuất nguyên liệu thành công!", "Thành công!");
                        }
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hệ thống đã xảy ra lỗi", "Xin lỗi!");
                    }
                }
                catch
                {
                    MessageBox.Show("Hệ thống đã xảy ra lỗi", "Xin lỗi!");
                }
            }
            else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Xin Lỗi!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValue_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (iFunction == 1)
                {
                    txtAfter.Text = (float.Parse(txtBefor.Text) + float.Parse(txtValue.Text)).ToString();
                }
                else if (iFunction == 2)
                {
                    txtAfter.Text = (float.Parse(txtBefor.Text) - float.Parse(txtValue.Text)).ToString();
                }
            }
            catch
            {

            }
        }
    }
}