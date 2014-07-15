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

        protected IDisplayInfo Display;

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
            return String.Format(Username + " " + Email + " " + Password + " " + Id);
        }

        public string DisplayInfo()
        {
            return ToString();
        }

        public virtual void Login(int option)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            Display = c.CreateDisplay(option);
            if (Display != null)
                Display.DisplayInfo("Login");
        }

        public virtual void Logout(int option)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            Display = c.CreateDisplay(option);
            if (Display != null) 
                Display.DisplayInfo("Logout");
        }
    }
}
