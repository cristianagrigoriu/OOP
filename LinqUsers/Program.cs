using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Shapes;

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
                new StudentUser("Harry Potter", "abc", 100, 90),
                new StudentUser("Hermione Granger", "ron", 10, 100),
                new TeacherUser("Albus Dumbledore", "stupefy", 1, 2000.5, "Potions")
            };

            Console.WriteLine("---User List---");
            users.ForEach(x => Console.WriteLine(x.DisplayInfo()));
            Console.WriteLine();

            //List<IUser> iUsers = users.ConvertAll<IUser>(x => (IUser) x);
            var iUsers = users.Select(x => new {Username = x.Username, Password = x.Password}).ToList();

            Console.WriteLine("---Converted List---");
            iUsers.ForEach(x => Console.WriteLine(x.Username + " " + x.Password));
            Console.WriteLine();

            List<User> admins = users.Where( x => x.Username.StartsWith("admin")).ToList();
            Console.WriteLine("Number of admins: {0}" , admins.Count);
            Console.WriteLine();

            List<User> firstTwoUsers = users.Take(2).OrderByDescending(x => x.Username).ToList();
            Console.WriteLine("---First Two Users---");
            firstTwoUsers.ForEach(x => Console.WriteLine(x.DisplayInfo()));
            Console.WriteLine();

            //e diferit de fiecare data
            User newestUser = users.OrderByDescending(x => x.InsertTime).FirstOrDefault();
            Console.WriteLine("Newest user is {0}", newestUser.DisplayInfo());
            Console.WriteLine();
           
            User minIdUser = users.OrderBy(x => x.Id).FirstOrDefault();
            Console.WriteLine("User with minimum id: {0}", minIdUser.DisplayInfo());
            Console.WriteLine();

            User lookedForUser = users.Where(x => x.Equals(minIdUser)).FirstOrDefault();
            Console.WriteLine("I looked for {0}", lookedForUser.DisplayInfo());

            List<IObject> objects = new List<IObject>
            {
                new StudentUser("Harry Potter", "horcrux", 200, 8),
                new TeacherUser("Severus Snape", "lily", 201, 8000, "Potions"),
                new Rectangle("purple", 10, 10),
                new Triangle(3, 8.5)
            };

            Console.WriteLine("\n---Display General Info---");
            ListInfo l = new ListInfo();
            l.DisplayInfoGeneral(objects);

            Console.WriteLine("\n---Display Generic Info---");
            l.DisplayInfoGeneric(objects);
        }
    }
}
