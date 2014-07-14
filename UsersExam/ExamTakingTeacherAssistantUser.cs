using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ExamTakingTeacherAssistantUser : User, IExamDelegate
    {
        public void TakeExam()
        {
            SuperviseStudents();
            GradeStudents();
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
