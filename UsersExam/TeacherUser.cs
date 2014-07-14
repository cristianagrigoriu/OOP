using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersExam;

namespace UsersExam
{
    class TeacherUser : User
    {
        private double Salary;
        private string Subject;
        private IExamDelegate examBehaviour;

        public TeacherUser(string username, string password, int id, double salary, string subject) : base(username, password, id)
        {
            this.Salary = salary;
            this.Subject = subject;
            examBehaviour = new ExamTakingTeacherUser();
        }

        public override string ToString()
        {
            return base.ToString() + " " + Salary + " " + Subject;
        }

        public override string Login()
        {
            return String.Format("Teacher {0} has logged in.", username);
        }

        public override string Logout()
        {
            return String.Format("Teacher {0} has logged out.", username);
        }

        public string TakeExam()
        {
            return examBehaviour.TakeExam();
        }
    }
}
