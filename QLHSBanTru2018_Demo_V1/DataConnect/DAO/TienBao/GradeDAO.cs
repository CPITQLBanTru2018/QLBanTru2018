using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace DataConnect.DAO.TienBao
{
   public class GradeDAO
    {
        QLHSSmartKidsDataContext db;
        Table<Grade> GradeTable;
        public GradeDAO()
        {
            db = new QLHSSmartKidsDataContext();
            GradeTable = db.GetTable<Grade>();
        }

        public List<Grade> ListAllGrade()
        {
            return (from g in GradeTable
                    select g).ToList();
        }

        public List<Grade> ListBySemester(int SemesterID)
        {
            return (from g in GradeTable
                    where g.SemesterID == SemesterID
                    select g).ToList();
        }

        public Grade GetByGradeID(int GradeID)
        {
            return GradeTable.SingleOrDefault(x => x.GradeID == GradeID);
        }
        public bool InsertClass(Grade entity)
        {
            try
            {
                GradeTable.InsertOnSubmit(entity);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditClass(Grade entity)
        {
            try
            {
                Grade obj = GradeTable.Single(x => x.GradeID == entity.GradeID);
                obj.Name = entity.Name;
                obj.Note = entity.Note;
                obj.Status = entity.Status;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int GradeID)
        {
            try
            {
                Grade obj = GradeTable.Single(x => x.GradeID == GradeID);
                obj.Status = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
