using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ExamTakingTeacherAssistantUser : User, IExamDelegate
    {
        public string TakeExam()
        {
            StringBuilder result = new StringBuilder();
            result.Append(SuperviseStudents());
            result.AppendLine();
            result.Append(GradeStudents());
            result.AppendLine();
            return result.ToString();
        }

        private string GradeStudents()
        {
            return new StringBuilder("Teacher assistant " + username + " is grading students.").ToString();
        }

        private string SuperviseStudents()
        {
            return new StringBuilder("Teacher assistant " + username + " is supervising students.").ToString();
        }
    }
}
