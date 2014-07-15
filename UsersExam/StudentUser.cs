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

        public StudentUser(string username, string password, int id, int grade) : base(username, password, id)
        {
            this.Grade = grade;
            examBehaviour = new ExamTakingStudentUser();
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + " " + Grade);
        }

        public override void Login(int option)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            Display = c.CreateDisplay(option);
            if (Display != null)
                Display.DisplayInfo(String.Format("Student {0} has logged in.", username));
        }

        public override void Logout(int option)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            Display = c.CreateDisplay(option);
            if (Display != null)
                Display.DisplayInfo(String.Format("Student {0} has logged out.", username));
        }

        public void TakeExam(int writeOption)
        {
            examBehaviour.TakeExam(writeOption, this.Username);
        }
    }
}
