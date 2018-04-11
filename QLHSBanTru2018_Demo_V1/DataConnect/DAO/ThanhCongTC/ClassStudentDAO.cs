using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC
{
    public class ClassStudentDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public static int StudentID = 0;
        public List<Student> ListStudent(int ClassID)
        {
            var a = dt.Student_Classes.Where(t => t.ClassID == ClassID);
            a.ToList();
            List<Student> ListStudent = new List<Student>();
            foreach (var i in a)
            {
                Student b = new Student();
                b = dt.Students.FirstOrDefault(t => t.StudentID == i.StudentID);
                ListStudent.Add(b);
            }
            return ListStudent;
        }
        public Student lookForStuden(int studentID)
        {
            Student a = dt.Students.FirstOrDefault(t => t.StudentID == studentID);
            return a;
        }
    }
}
