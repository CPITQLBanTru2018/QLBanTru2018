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
using DataConnect.DAO.ThanhCongTC;
using DataConnect;

namespace QLHSBanTru2018_Demo_V1.QLThuChi.DotThu.KeHoachThu
{
    public partial class FrThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public FrThanhToan()
        {
            InitializeComponent();
        }
        public void LoadKhoaPhi()
        {
            ReceivableDetail_StudentDAO dt = new ReceivableDetail_StudentDAO();
            ReceivableDetailDAO dc = new ReceivableDetailDAO();
            List<ReceivableDetail_Student> a = new List<ReceivableDetail_Student>();
            List<ReceivableDetail> b = new List<ReceivableDetail>();
            a = dt.ListReceivableDetail_Student(ClassStudentDAO.StudentID);
            foreach (var i in a)
            {
                ReceivableDetail c = new ReceivableDetail();
                c = dc.ReceivableDetaiByStudenID(i.ReceivableDetailID, ReceivableIDAO.ReceivableID);
                if (c!=null)
                {
                    b.Add(c);
                }
                
            }
            grDanhsachkhoanthu.DataSource = b;
        }
        private void FrThanhToan_Load(object sender, EventArgs e)
        {
            LoadKhoaPhi();
        }
    }
}