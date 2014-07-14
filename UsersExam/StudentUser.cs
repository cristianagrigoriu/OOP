using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersExam;

namespace UsersExam
{
    class StudentUser : User
    {
        private int Grade;
        private IExamDelegate examBehaviour;
        private IDisplayInfo df;

        public StudentUser(string username, string password, int id, int grade, int option) : base(username, password, id)
        {
            this.Grade = grade;
            examBehaviour = new ExamTakingStudentUser();
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            df = c.CreateDisplay(option);
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + " " + Grade);
        }

        public override void Login()
        {
            df.DisplayInfo(String.Format("Student {0} has logged in.", username));
        }

        public override void Logout()
        {
            df.DisplayInfo(String.Format("Student {0} has logged out.", username));
        }

        public void TakeExam()
        {
            examBehaviour.TakeExam();
        }
    }
}
