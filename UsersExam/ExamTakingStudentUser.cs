using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    internal class ExamTakingStudentUser : User, IExamDelegate
    {
        private IExamDelegate examBehaviour;
        private IDisplayInfo df;

        public void TakeExam()
        {
            PrepareForExam();
            GoToExam();
            ReceiveGrade();
        }

        private void ReceiveGrade()
        {
            //"Student " + this.Username + " receives grade for exam.";
        }

        private void GoToExam()
        {
            //"Student " + username + " is currently taking the exam.";
        }

        private void PrepareForExam()
        {
            //StringBuilder("Student " + username + " is preparing for exam.";
        }
    }
}
