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
        private IExamDelegate examBehaviour;

        public SecretaryUser(string username, string password, int id, int numberOfDocuments) : base(username, password, id)
        {
            this.NumberOfDocuments = numberOfDocuments;
            examBehaviour = new ExamNotTakingUser();
        }

        public void TakeExam()
        {
            examBehaviour.TakeExam();
        }

        public override void Login()
        {
            String.Format("Secretary {0} has logged in.", username);
        }

        public override void Logout()
        {
            String.Format("Secretary {0} has logged out.", username);
        }
    }
}
