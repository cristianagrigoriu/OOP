using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    internal class ExamTakingStudentUser : User, IExamDelegate
    {
        public string TakeExam()
        {
            StringBuilder result = new StringBuilder();
            result.Append(PrepareForExam());
            result.AppendLine();
            result.Append(GoToExam());
            result.AppendLine();
            result.Append(ReceiveGrade());
            result.AppendLine();
            return result.ToString();
        }

        private string ReceiveGrade()
        {
            return new StringBuilder("Student " + this.Username + " receives grade for exam.").ToString();
        }

        private string GoToExam()
        {
            return new StringBuilder("Student " + username + " is currently taking the exam.").ToString();
        }

        private string PrepareForExam()
        {
            return new StringBuilder("Student " + username + " is preparing for exam.").ToString();
        }
    }
}
