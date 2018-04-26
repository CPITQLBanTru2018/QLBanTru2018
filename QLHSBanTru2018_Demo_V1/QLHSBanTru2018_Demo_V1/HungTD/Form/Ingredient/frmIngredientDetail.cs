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
    public partial class frmIngredientDetail : DevExpress.XtraEditors.XtraForm
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
        public frmIngredientDetail()
        {
            InitializeComponent();
        }

        private void frmIngredientDetail_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadDetail();
        }
        private void LoadDetail()
        {
            if (iFunction == 2)
            {
                try
                {
                    txtName.Text = ingredient.Name;
                    cbbIngredientTypeID.SelectedValue = ingredient.IngredientTypeID;
                    txtUnit.Text = ingredient.Unit;
                    txtQuantityOfUnit.Text = ingredient.QuantityOfUnit.ToString();
                    chkStatus.Checked = ingredient.Status;

                    txtKcal.Text = ingredient.Kcal.ToString();
                    txtProtein.Text = ingredient.Protein.ToString();
                    txtFat.Text = ingredient.Fat.ToString();
                    txtGlucose.Text = ingredient.Glucose.ToString();
                    txtFiber.Text = ingredient.Fiber.ToString();
                    txtCanxi.Text = ingredient.Canxi.ToString();
                    txtIron.Text = ingredient.Iron.ToString();
                    txtPhotpho.Text = ingredient.Photpho.ToString();
                    txtKali.Text = ingredient.Kali.ToString();
                    txtVitaminA.Text = ingredient.VitaminA.ToString();
                    txtVitaminB1.Text = ingredient.VitaminB1.ToString();
                    txtVitaminC.Text = ingredient.VitaminC.ToString();
                    txtAxitFolic.Text = ingredient.AxitFolic.ToString();
                    txtCholesterol.Text = ingredient.Cholesterol.ToString();
                }
                catch
                {

                }
            }
        }
        private void FillCombobox()
        {
            cbbIngredientTypeID.DataSource = new IngredientTypeDAO().ListAllActive();
            cbbIngredientTypeID.DisplayMember = "Name";
            cbbIngredientTypeID.ValueMember = "IngredientTypeID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                try
                {
                    DataConnect.Ingredient entity = new DataConnect.Ingredient();
                    entity.Name = txtName.Text;
                    entity.IngredientTypeID = int.Parse(cbbIngredientTypeID.SelectedValue.ToString());
                    entity.Unit = txtUnit.Text;
                    entity.QuantityOfUnit = int.Parse(txtQuantityOfUnit.Text);
                    entity.Status = chkStatus.Checked;

                    entity.Kcal = int.Parse(txtKcal.Text);
                    entity.Protein = int.Parse(txtProtein.Text);
                    entity.Fat = int.Parse(txtFat.Text);
                    entity.Glucose = int.Parse(txtGlucose.Text);
                    entity.Fiber = int.Parse(txtFiber.Text);
                    entity.Canxi = int.Parse(txtCanxi.Text);
                    entity.Iron = int.Parse(txtIron.Text);
                    entity.Photpho = int.Parse(txtPhotpho.Text);
                    entity.Kali = int.Parse(txtKali.Text);
                    entity.Natri = int.Parse(txtNatri.Text);
                    entity.VitaminA = int.Parse(txtVitaminA.Text);
                    entity.VitaminB1 = int.Parse(txtVitaminB1.Text);
                    entity.VitaminC = int.Parse(txtVitaminC.Text);
                    entity.AxitFolic = int.Parse(txtAxitFolic.Text);
                    entity.Cholesterol = int.Parse(txtCholesterol.Text);
                    if (iFunction == 1)
                    {
                        if(new IngredientDAO().Insert(entity) > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thành công!");
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hệ thống đã xảy ra lỗi", "Xin lỗi!");
                        }
                    }
                    else if (iFunction == 2)
                    {
                        entity.IngredientID = ingredient.IngredientID;
                        if(new IngredientDAO().Edit(entity) == true)
                        {
                            MessageBox.Show("Cập nhật công!", "Thành công!");
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hệ thống đã xảy ra lỗi", "Xin lỗi!");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình nhập số liện!", "Xin Lỗi!");
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
    }
}