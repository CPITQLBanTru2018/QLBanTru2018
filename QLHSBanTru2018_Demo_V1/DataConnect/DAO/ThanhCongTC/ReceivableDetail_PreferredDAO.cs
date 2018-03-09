using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC
{
    public class ReceivableDetail_PreferredDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public bool Insert(ReceivableDetail_Preferred entity)
        {
            ReceivableDetail_Preferred a = new ReceivableDetail_Preferred();
            a.ReceivableDetailID = entity.ReceivableDetailID;
            a.PreferredID = entity.PreferredID;
            a.Percent = entity.Percent;
            a.Status = entity.Status;
            dt.ReceivableDetail_Preferreds.InsertOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public bool Edit(ReceivableDetail_Preferred entity)
        {
            ReceivableDetail_Preferred a = dt.ReceivableDetail_Preferreds.Where(t => t.ReceivableDetailID == entity.ReceivableDetailID && t.PreferredID == entity.PreferredID).FirstOrDefault();
            a.ReceivableDetailID = entity.ReceivableDetailID;
            a.PreferredID = entity.PreferredID;
            a.Percent = entity.Percent;
            a.Status = entity.Status;
            dt.SubmitChanges();
            return true;
        }
        public bool Remove(ReceivableDetail_Preferred entity)
        {
            ReceivableDetail_Preferred a = dt.ReceivableDetail_Preferreds.Where(t => t.ReceivableDetailID == entity.ReceivableDetailID && t.PreferredID == entity.PreferredID).FirstOrDefault();
            dt.ReceivableDetail_Preferreds.DeleteOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public List<ReceivableDetail_Preferred> ListReceivableDetail_preferred()
        {
            var a = dt.ReceivableDetail_Preferreds;
            return a.ToList();
        }
    }
}
