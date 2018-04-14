﻿using System;
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

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.WorkProgress
{
    public partial class frmWorkProgressList : DevExpress.XtraEditors.XtraUserControl
    {
        public frmWorkProgressList()
        {
            InitializeComponent();
        }

        private void frmWorkProgressList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillGridControls();
        }
        private void FillGridControls()
        {
            gcMain.DataSource = new DivisionDAO().ListAll();
        }
    }
}
