using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersExam;

namespace UsersExam
{
    class TeacherUser : User, IExamTakingUser
    {
        private double Salary;
        private string Subject;

        public TeacherUser(string username, string password, int id, double salary, string subject) : base(username, password, id)
        {
            this.Salary = salary;
            this.Subject = subject;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Salary + " " + Subject;
        }

        public override void Login()
        {
            Console.WriteLine("Teacher {0} has logged in.", username);
        }

        public override void Logout()
        {
            Console.WriteLine("Teacher {0} has logged out.", username);
        }

        public void TakeExam()
        {
            PrepareQuestions();
            SuperviseStudents();
            GradeStudents();
        }

        private void GradeStudents()
        {
            Console.WriteLine("Teacher {0} is grading students.", username);
        }

        private void SuperviseStudents()
        {
            Console.WriteLine("Teacher {0} is supervising students.", username);
        }

        private void PrepareQuestions()
        {
            Console.WriteLine("Teacher {0} is preparing questions.", username);
        }
    }
}
