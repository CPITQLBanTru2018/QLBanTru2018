using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.TienBao
{
   public class StudentParentsDAO
    {
        QLHSSmartKidsDataContext db;
        Table<StudentParent> StudentParentsTable;
        public StudentParentsDAO()
        {
            db = new QLHSSmartKidsDataContext();
            StudentParentsTable = db.GetTable<StudentParent>();
        }

        public List<StudentParent> ListParents(int StudentID)
        {
            Table<StudentParent> StudentParentsTable = db.GetTable<StudentParent>();
            var query = from p in StudentParentsTable
                        where p.StudentID.Equals(StudentID)
                        select p;
            return query.ToList();
        }
        //public int GetParent(int StudentID)
        //{
        //    Table<StudentParent> StudentParentsTable = db.GetTable<StudentParent>();
        //    var query = from p in StudentParentsTable
        //                where p.StudentID.Equals(StudentID)
        //                select p;
        //    return (int)query.;

        //}

        public StudentParent GetByID(int StudentID)
        {
            StudentParentsTable = db.GetTable<StudentParent>();
            return db.StudentParents.SingleOrDefault(x => x.StudentID == StudentID);
        }
        public bool ParentsInsert(StudentParent entity)
        {
            try
            {
                StudentParentsTable = db.GetTable<StudentParent>();
                StudentParentsTable.InsertOnSubmit(entity);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ParentsUpdate(StudentParent entity)
        {
            try
            {
                StudentParentsTable = db.GetTable<StudentParent>();
                StudentParent model = StudentParentsTable.SingleOrDefault(x => x.StudentParentsID.Equals(entity.StudentParentsID));
                model.Password = entity.Password;
                model.FatherName = entity.FatherName;
                model.FatherJob = entity.FatherJob;
                model.FatherBirthday = entity.FatherBirthday;
                model.FatherPhone = entity.FatherPhone;
                model.MotherName = entity.MotherName;
                model.MotherJob = entity.MotherJob;
                model.MotherBirthday = entity.MotherBirthday;
                model.MotherPhone = entity.MotherPhone;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public bool StudentEdit(Student entity)
        //{
        //    try
        //    {
        //        Student = db.GetTable<Student>();
        //        Student obj = Student.Single(x => x.StudentID == entity.StudentID);
        //        obj.StudentCode = entity.StudentCode;
        //        obj.FirstName = entity.FirstName;
        //        obj.LastName = entity.LastName;
        //        obj.Birthday = entity.Birthday;
        //        obj.Gender = entity.Gender;
        //        obj.Image = entity.Image;
        //        obj.Hobby = entity.Hobby;
        //        obj.Talent = entity.Talent;
        //        obj.LocationID = entity.LocationID;
        //        obj.AdressDetail = entity.AdressDetail;
        //        obj.EthnicGroupID = entity.EthnicGroupID;
        //        obj.ReligionID = entity.ReligionID;
        //        obj.PreferredID = entity.PreferredID;
        //        obj.Note = entity.Note;
        //        obj.Status = entity.Status;
        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public bool ParentsDelete(int StudentParentsID)
        {
            try
            {
                StudentParentsTable = db.GetTable<StudentParent>();
                StudentParent model = StudentParentsTable.SingleOrDefault(x => x.StudentID.Equals(StudentParentsID));

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
