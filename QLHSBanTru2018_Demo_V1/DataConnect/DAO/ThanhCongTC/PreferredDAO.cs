using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC
{
    public class PreferredDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public bool Insert(Preferred entity)
        {
            Preferred a = new Preferred();
            a.Name = entity.Name;
            a.Status = entity.Status;
            dt.Preferreds.InsertOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public bool Edit(Preferred entity)
        {
            Preferred a = dt.Preferreds.Where(t => t.PreferredID == entity.PreferredID).FirstOrDefault();
            a.Name = entity.Name;
            a.Status = entity.Status;
            dt.SubmitChanges();
            return true;
        }
        public bool Remove(Preferred entity)
        {
            Preferred a = dt.Preferreds.Where(t => t.PreferredID == entity.PreferredID).FirstOrDefault();
            dt.Preferreds.DeleteOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public List<Preferred> ListPreferred()
        {
            var a = dt.Preferreds;
            return a.ToList();
        }
    }
}
