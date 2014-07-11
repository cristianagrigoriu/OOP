using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsers
{
    internal class User : IUser
    {
        protected string username;
        public string Username { get { return username; } set { username = value; } }

        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public DateTime InsertTime { get; set; }

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
    }
}
