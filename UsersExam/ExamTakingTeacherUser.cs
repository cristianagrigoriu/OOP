using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ExamTakingTeacherUser : User, IExamDelegate
    {
        public void TakeExam()
        {
            PrepareQuestions();
            SuperviseStudents();
            GradeStudents();
        }

        private void GradeStudents()
        {
            //"Teacher " + username + " is grading students.");
        }

        private void SuperviseStudents()
        {
            //"Teacher " + username + " is supervising students.");
        }

        private void PrepareQuestions()
        {
            //"Teacher " + username + " is preparing questions.");
        }
    }
}
