using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC
{
    public class ReceivableIDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public static int ReceivableID = 0;
        public int Insert(Receivable entity)
        {
            Receivable a = new Receivable();
            a.Name = entity.Name;
            a.TotalPrice = entity.TotalPrice;
            a.StartDate = entity.StartDate;
            a.EndDate = entity.EndDate;
            a.CreatedDate = entity.CreatedDate;
            a.Status = entity.Status;
            //a.RevenueID = entity.RevenueID;
            dt.Receivables.InsertOnSubmit(a);
            dt.SubmitChanges();
            return a.ReceivableID;
        }
        public bool Edit(Receivable entity)
        {
            Receivable a = dt.Receivables.Where(t => t.ReceivableID == entity.ReceivableID).FirstOrDefault();
            a.Name = entity.Name;
            a.TotalPrice = entity.TotalPrice;
            a.StartDate = entity.StartDate;
            a.EndDate = entity.EndDate;
            a.CreatedDate = entity.CreatedDate;
            a.Status = entity.Status;
            //a.RevenueID = entity.RevenueID;
            dt.SubmitChanges();
            return true;
        }
        public bool Remove(Receivable entity)
        {
            Receivable a = dt.Receivables.Where(t => t.ReceivableID == entity.ReceivableID).FirstOrDefault();
            dt.Receivables.DeleteOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public List<Receivable> ListReceivable()
        {
            var a = dt.Receivables;
            return a.ToList();
        }
    }
}
