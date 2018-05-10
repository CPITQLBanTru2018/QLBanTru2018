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

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Dish
{
    public partial class frmDishDetail : DevExpress.XtraEditors.XtraForm
    {
        public int iFuntion = 0;
        public DataConnect.Dish dish;
        public void setFunction(int function)
        {
            this.iFuntion = function;
        }
        public void setDish(int dishID)
        {
            this.dish = new DishDAO().GetByID(dishID);
        }
        public void setTitle(string title)
        {
            this.Text = title;
        }
        public frmDishDetail()
        {
            InitializeComponent();
        }

        private void frmDishDetail_Load(object sender, EventArgs e)
        {

        }
    }
}