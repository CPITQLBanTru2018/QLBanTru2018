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
    public partial class frmIngredient : DevExpress.XtraEditors.XtraUserControl
    {
        public frmIngredient()
        {
            InitializeComponent();
        }

        private void frmIngredient_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillGridControl();
        }
        private void FillGridControl()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
