using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User("admin", "000", 13),
                new User("admin2", "123", 17),
                new User("Ringo", "s;kf", 333),
                new StudentUser("HarryPotter", "abc", 100, 90),
                new StudentUser("HermioneGranger", "ron", 1, 100),
                new TeacherUser("Albus Dumbledore", "stupefy", 3, 2000.5, "Potions")
            };
            
            //List<IUser> iUsers = users.ConvertAll<IUser>(x => (IUser) x);
            var iUsers = users.Select(x => new {Username = x.Username, Password = x.Password}).ToList();

            Console.WriteLine("---Converted List---");
            iUsers.ForEach(x => Console.WriteLine(x));

            List<User> admins = users.Where( x => x.Username.StartsWith("admin")).ToList();
            Console.WriteLine("Number of admins: {0}" , admins.Count);

            List<User> firstTwoUsers = users.Take(2).OrderByDescending(x => x.Username).ToList();
            Console.WriteLine("---First Two Users---");
            firstTwoUsers.ForEach(x => Console.WriteLine(x));

            //e diferit de fiecare data
            User newestUser = users.OrderByDescending(x => x.InsertTime).FirstOrDefault();
            Console.WriteLine("Newest user is {0}", newestUser);
           
            User minIdUser = users.OrderBy(x => x.Id).FirstOrDefault();
            Console.WriteLine("User with minimum id: {0}", minIdUser);

            User lookedForUser = users.Where(x => x.Equals(minIdUser)).FirstOrDefault();
            Console.WriteLine("I looked for {0}", lookedForUser);
        }
    }
}
