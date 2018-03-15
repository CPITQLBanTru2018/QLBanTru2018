using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC
{
     public class ReceivableDetailDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public int Insert(ReceivableDetail entity)
        {
            ReceivableDetail a = new ReceivableDetail();
            a.ReceivableID = entity.ReceivableID;
            a.Name = entity.Name;
            a.Price = entity.Price;
            a.SalePrice = entity.SalePrice;
            a.Status = entity.Status;
            //a.Revenue = entity.Revenue;
            dt.ReceivableDetails.InsertOnSubmit(a);
            dt.SubmitChanges();
            return a.ReceivableDetailID;
        }
        public bool Edit(ReceivableDetail entity)
        {
            ReceivableDetail a = dt.ReceivableDetails.Where(t => t.ReceivableDetailID == entity.ReceivableDetailID).FirstOrDefault();
            a.ReceivableID = entity.ReceivableID;
            a.Name = entity.Name;
            a.Price = entity.Price;
            a.SalePrice = entity.SalePrice;
            a.Status = entity.Status;
            //a.Revenue = entity.Revenue;
            dt.SubmitChanges();
            return true;
        }
        public bool Remove(ReceivableDetail entity)
        {
            ReceivableDetail a = dt.ReceivableDetails.Where(t => t.ReceivableDetailID == entity.ReceivableDetailID).FirstOrDefault();
            dt.ReceivableDetails.DeleteOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public List<ReceivableDetail> ListReceivableDetail(int MDT)
        {
            var a = dt.ReceivableDetails.Where(t=>t.ReceivableID==MDT);
            return a.ToList();
        }
        public static List<ReceivableDetail> ListDemoReceivableDetail = new List<ReceivableDetail>();
    }
}
