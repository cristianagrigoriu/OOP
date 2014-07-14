using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    public class User
    {
        protected string username;
        public string Username { get { return username; } set { username = value; } }

        protected string email;
        public string Email { get { return email; } set { email = value; } }

        protected string password;
        public string Password { get { return password; } set { password = value; } }

        protected int id;
        public int Id { get { return id; } set { id = value; } }

        protected DateTime insertTime ;
        public DateTime InsertTime { get { return insertTime; } set { insertTime = value; } }

        public User(string username, string password, int id)
        {
            this.Username = username;
            this.Password = password;
            this.Id = id;
            this.InsertTime = DateTime.Now;
        }

        public User() {}

        public override string ToString()
        {
            return Username + " " + Email + " " + Password + " " + Id;
        }

        public string DisplayInfo()
        {
            return ToString();
        }

        public virtual void Login() {}
        public virtual void Logout() {}
    }
}
