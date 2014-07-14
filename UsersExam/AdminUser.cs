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
        private IExamDelegate examBehaviour;

        public AdminUser(string username, string password, int id, string responsibility) : base(username, password, id)
        {
            this.Resposibility = responsibility;
            examBehaviour = new ExamNotTakingUser();
        }

        public void TakeExam()
        {
            examBehaviour.TakeExam();
        }

        public override void Login()
        {
            String.Format("Admin {0} has logged in.", username);
        }

        public override void Logout()
        {
            String.Format("Admin {0} has logged out.", username);
        }
    }
}
