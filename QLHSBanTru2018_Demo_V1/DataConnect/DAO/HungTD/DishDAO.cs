using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnect.ViewModel;

namespace DataConnect.DAO.HungTD
{
    public class DishDAO
    {
        QLHSSmartKidsDataContext db;
        Table<Dish> dishes;
        public DishDAO()
        {
            db = new QLHSSmartKidsDataContext();
            dishes = db.GetTable<Dish>();
        }
        public List<DishViewModel> ListAll()
        {
            return null;
        }
        public Dish GetByID(int dishID)
        {
            return dishes.FirstOrDefault(x => x.DishID.Equals(dishID));
        }
    }
}