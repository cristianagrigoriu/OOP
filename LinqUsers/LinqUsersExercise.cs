using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsers
{
    class LinqUsersExercise
    {
        public List<User> CreateAndInitializeUsers()
        {
            return new List<User>
            {
                new User("admin", "000", 13),
                new User("admin2", "123", 17),
                new User("Ringo", "s;kf", 333),
                new StudentUser("Harry Potter", "abc", 100, 90),
                new StudentUser("Hermione Granger", "ron", 10, 100),
                new TeacherUser("Albus Dumbledore", "stupefy", 1, 2000.5, "Potions")
            };
        }

        /*public List<> SelectVirtualUsers(List<User> users)
        {
         * //List<IUser> iUsers = users.ConvertAll<IUser>(x => (IUser) x);
            var iUsers = users.Select(x => new {Username = x.Username, Password = x.Password}).ToList();
            return iUsers;
        }*/

        public int CountAdmins(List<User> users)
        {
            List<User> admins = users.Where(x => x.Username.StartsWith("admin")).ToList();
            return admins.Count;
        }

        public List<User> FirstTwoUsers(List<User> users)
        {
            return users.Take(2).OrderByDescending(x => x.Username).ToList();
        }

        public User NewestUser(List<User> users)
        {
            //User newestUser = users.OrderByDescending(x => x.InsertTime).FirstOrDefault();
            return users.OrderByDescending(x => x.Id).FirstOrDefault();
        }

        public User MinimumId(List<User> users)
        {
            return users.OrderBy(x => x.Id).FirstOrDefault();
        }

        public User FindByObject(List<User> users, User lookedForUser)
        {
            return users.Where(x => x.Equals(lookedForUser)).FirstOrDefault();
        }

        public void ShowUsers(List<User> users, string message)
        {
            Console.WriteLine(message);
            users.ForEach(x => Console.WriteLine(x.DisplayInfo()));
            Console.WriteLine();
        }
    }
}
