using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnect;
using DataConnect.DAO.ThanhCongTC.TCViewModle;

namespace DataConnect.DAO.ThanhCongTC
{
    public class studentReceivableDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public static int CourseID = 0;
        public static int SemesterID = 0;
        public static int GradeID = 0;
        public static int ClassID = 0;
        public static int TherowFocust = 0;
        public List<Course> ListCourse()
        {
            var a = dt.Courses.OrderByDescending(t=>t.CourseID);
            return a.ToList();
        }
        public List<Semester> ListSemester()
        {
            var a = dt.Semesters.Where(t => t.CourseID == CourseID);
            return a.ToList();
        }
        public List<Grade> ListGrade()
        {
            var a = dt.Grades.Where(t => t.SemesterID == studentReceivableDAO.SemesterID);
            return a.ToList();
        }
        public List<Class> ListClass()
        {
            var a = dt.Classes.Where(t => t.GradeID == GradeID);
            return a.ToList();
        }
        Table<Class> classs;
        Table<Student_Class> StdClass;
        Table<Student> STD;
        Table<Preferred> preferred;
       
        
        public List<TCStudenViewModle> ListStudents()
        {
            classs = dt.GetTable<Class>();
            StdClass = dt.GetTable<Student_Class>();
            STD = dt.GetTable<Student>();
            preferred = dt.GetTable<Preferred>();
            
            var a = from b in classs
                    join c in StdClass on b.ClassID equals c.ClassID
                    join d in STD on c.StudentID equals d.StudentID
                    join e in preferred on d.PreferredID equals e.PreferredID
                   // join f in RDP on e.PreferredID equals f.PreferredID

                    where b.ClassID == 3
                    select new TCStudenViewModle
                    {
                        StudenID = d.StudentID,
                        FullName = d.FirstName + " " + d.LastName,
                        AdressDetail = d.AdressDetail,
                        Birthday = d.Birthday,
                        PreferredName = e.Name,
                        //Percent=f.Percent,
                        //TotalPrice=0,
                        //Status=true

                    };
                return a.ToList();
           
        }
        //public Link<TCStudenViewModle> listStudenReceivable()
        //{
        //    classs = dt.GetTable<Class>();

        
        //}
        
    }
}
