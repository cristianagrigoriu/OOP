using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    internal class ExamTakingStudentUser : User, IExamDelegate
    {
        private IDisplayInfo df;

        public void TakeExam(int option, string name)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            df = c.CreateDisplay(option);

            PrepareForExam(name);
            GoToExam(name);
            ReceiveGrade(name);    
        }

        private void ReceiveGrade(string name)
        {
            df.DisplayInfo("Student " + name + " receives grade for exam.");
        }

        private void GoToExam(string name)
        {
            df.DisplayInfo("Student " + name + " is currently taking the exam.");
        }

        private void PrepareForExam(string name)
        {
            df.DisplayInfo("Student " + name + " is preparing for exam.");
        }
    }
}
