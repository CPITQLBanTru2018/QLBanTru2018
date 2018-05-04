using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC.ChiTieu
{
    public class SpendSpeciesDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public bool Insert(SpendSpecy entity)
        {
            SpendSpecy a = new SpendSpecy();
            a.Name = entity.Name;
            a.CreatedDate = entity.CreatedDate;
            a.Status = false;
            dt.SpendSpecies.InsertOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public bool Edit(SpendSpecy spendSpecy)
        {
            SpendSpecy a = new SpendSpecy();
            a = dt.SpendSpecies.Where(t => t.SpendSpeciesID == spendSpecy.SpendSpeciesID).FirstOrDefault();
            a.Name = spendSpecy.Name;
            a.CreatedDate = spendSpecy.CreatedDate;
            a.Status = spendSpecy.Status;
            dt.SubmitChanges();
            return true;
        }
        public bool Remove(SpendSpecy spendSpecy)
        {
            SpendSpecy a = new SpendSpecy();
            a = dt.SpendSpecies.FirstOrDefault(t => t.SpendSpeciesID == spendSpecy.SpendSpeciesID);
            dt.SpendSpecies.DeleteOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
    }
}
