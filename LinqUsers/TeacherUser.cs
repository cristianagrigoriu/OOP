using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsers
{
    class TeacherUser : User
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
    }
}
