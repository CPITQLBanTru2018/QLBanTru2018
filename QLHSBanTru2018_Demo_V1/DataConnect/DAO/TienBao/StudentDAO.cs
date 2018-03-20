using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DataConnect.ViewModel;

namespace DataConnect.DAO.TienBao
{
   public class StudentDAO
    {
        QLHSSmartKidsDataContext db = new QLHSSmartKidsDataContext();

        Table<Student> Student;
        Table<StudentParent> StudentParent;
        Table<Student_Class> Student_Class;


        public List<Student> ListAll()
        {
            Student = db.GetTable<Student>();
            var query = from e in Student
                        select e;
            return query.ToList();
        }
        public List<StudentViewModel> ListStudentByClass(int ClassID)
        {
            Student = db.GetTable<Student>();
            StudentParent = db.GetTable<StudentParent>();
            Student_Class = db.GetTable<Student_Class>();
            var query = from S in Student
                        join SP in StudentParent
                        on S.StudentID equals SP.StudentID
                        join SC in Student_Class
                        on S.StudentID equals SC.StudentID
                        where SC.ClassID.Equals(ClassID)
                        select new StudentViewModel
                        {
                            StudentID = S.StudentID,
                            StudentCode = S.StudentCode,
                            FirstName = S.FirstName,
                            LastName = S.LastName,
                            Birthday = S.Birthday,
                            Gender = S.Gender,
                            AdressDetail = S.AdressDetail,
                            FatherName = SP.FatherName,
                            FatherJob = SP.FatherJob,
                            MotherName = SP.MotherName,
                            MotherJob = SP.MotherJob,
                            Image = S.Image == null ? null : S.Image.ToArray(),
                            Status = S.Status
                        };
            List<StudentViewModel> list = query.ToList();
            return list;
        }

        public bool StudentInsert(Student entity)
        {
            try
            {
                Student = db.GetTable<Student>();
                Student.InsertOnSubmit(entity);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool StudentUpdate(Student entity)
        {
            try
            {
                Student = db.GetTable<Student>();
                Student model = Student.SingleOrDefault(x => x.StudentID.Equals(entity.StudentID));
                model.StudentCode = entity.StudentCode;
                model.FirstName = entity.FirstName;
                model.LastName = entity.LastName;
                model.Birthday = entity.Birthday;
                model.Gender = entity.Gender;
                model.Image = entity.Image;
                model.Hobby = entity.Hobby;
                model.Talent = entity.Talent;
                model.AdressDetail = entity.AdressDetail;
                model.EthnicGroupID = entity.EthnicGroupID;
                model.ReligionID = entity.ReligionID;
                model.PreferredID = entity.PreferredID;
                model.LocationID = entity.LocationID;
                model.Note = entity.Note;
                model.Status = entity.Status;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool StudentEdit(Student entity)
        {
            try
            {
                Student = db.GetTable<Student>();
                Student obj = Student.Single(x => x.StudentID == entity.StudentID);
                obj.StudentCode = entity.StudentCode;
                obj.FirstName = entity.FirstName;
                obj.LastName = entity.LastName;
                obj.Birthday = entity.Birthday;
                obj.Gender = entity.Gender;
                obj.Image = entity.Image;
                obj.Hobby = entity.Hobby;
                obj.Talent = entity.Talent;
                obj.LocationID = entity.LocationID;
                obj.AdressDetail = entity.AdressDetail;
                obj.EthnicGroupID = entity.EthnicGroupID;
                obj.ReligionID = entity.ReligionID;
                obj.PreferredID = entity.PreferredID;
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
        public bool StudentDelete(int StudentID)
        {
            try
            {
                Student = db.GetTable<Student>();
                Student model = Student.SingleOrDefault(x => x.StudentID.Equals(StudentID));
                model.Status = false;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Student GetByID(int StudentID)
        {
            Student = db.GetTable<Student>();
            return db.Students.SingleOrDefault(x => x.StudentID == StudentID);
        }
    }
}
