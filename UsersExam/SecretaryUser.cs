using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class SecretaryUser : User
    {
        public int NumberOfDocuments { get; set; }

        public SecretaryUser(string username, string password, int id, int numberOfDocuments) : base(username, password, id)
        {
            this.NumberOfDocuments = numberOfDocuments;
        }

        public override string Login()
        {
            return String.Format("Secretary {0} has logged in.", username);
        }

        public override string Logout()
        {
            return String.Format("Secretary {0} has logged out.", username);
        }
    }
}
