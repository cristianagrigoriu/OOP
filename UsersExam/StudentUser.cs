using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersExam;

namespace UsersExam
{
    class StudentUser : User, IExamTakingUser
    {
        private int Grade;

        public StudentUser(string username, string password, int id, int grade) : base(username, password, id)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Grade;
        }

        public override void Login()
        {
            Console.WriteLine("Student {0} has logged in.", username);
        }

        public override void Logout()
        {
            Console.WriteLine("Student {0} has logged out.", username);
        }

        public void TakeExam()
        {
            PrepareForExam();
            GoToExam();
            ReceiveGrade();
        }

        private void ReceiveGrade()
        {
            Console.WriteLine("Student {0} receives grade for exam.", username);
        }

        private void GoToExam()
        {
            Console.WriteLine("Student {0} is currently taking the exam.", username);
        }

        private void PrepareForExam()
        {
            Console.WriteLine("Student {0} is preparing for exam.", username);
        }
    }
}
