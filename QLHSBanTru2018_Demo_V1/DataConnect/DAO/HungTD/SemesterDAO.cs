using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.HungTD
{
    public class SemesterDAO
    {
        QLHSSmartKidsDataContext db;
        Table<Semester> semester;
        public SemesterDAO()
        {
            db = new QLHSSmartKidsDataContext();
            semester = db.GetTable<Semester>();
        }
        public List<Semester> ListAll()
        {
            return (from s in semester select s).ToList();
        }
        public List<Semester> ListByCourseID(int courseID)
        {
            return (from s in semester
                    where s.CourseID == courseID
                    select s).ToList();
        }
        public Semester GetBySemesterID(int semesterID)
        {
            return semester.SingleOrDefault(x => x.SemesterID == semesterID);
        }
        public bool Insert(Semester entity)
        {
            try
            {
                semester.InsertOnSubmit(entity);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Edit(Semester entity)
        {
            try
            {
                Semester obj = semester.Single(x => x.SemesterID == entity.SemesterID);
                obj.StartDate = entity.StartDate;
                obj.EndDate = entity.EndDate;
                obj.Status = entity.Status;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int semesterID)
        {
            try
            {
                Semester obj = semester.Single(x => x.SemesterID == semesterID);
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
