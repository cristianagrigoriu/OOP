using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class AdminUser : User
    {
        public string Resposibility { get; set; }

        public AdminUser(string username, string password, int id, string responsibility) : base(username, password, id)
        {
            this.Resposibility = responsibility;
        }

        public override string Login()
        {
            return String.Format("Admin {0} has logged in.", username);
        }

        public override string Logout()
        {
            return String.Format("Admin {0} has logged out.", username);
        }
    }
}
