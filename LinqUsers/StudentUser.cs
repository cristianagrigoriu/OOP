using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsers
{
    class StudentUser : User
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
    }
}
