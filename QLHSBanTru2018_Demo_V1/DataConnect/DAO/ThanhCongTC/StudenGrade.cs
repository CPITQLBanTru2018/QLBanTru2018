using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC
{
    public class StudenGrade
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public Semester lookforSemester(int maky)
        {
            Semester a = dt.Semesters.FirstOrDefault(t => t.SemesterID == maky);
            return a;
        }
        public Grade lookforGrade(int makhoi)
        {
            Grade a = dt.Grades.FirstOrDefault(t => t.GradeID == makhoi);
            return a;
        }
    }
}
