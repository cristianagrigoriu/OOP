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
            LinqUsersExercise exercise = new LinqUsersExercise();
            List<User> users = exercise.CreateAndInitializeUsers();
            exercise.ShowUsers(users, "---User List---");

            var iUsers = users.Select(x => new {x.Username, x.Password}).ToList();
            Console.WriteLine("---Converted List---");
            iUsers.ForEach(x => Console.WriteLine(x.Username + " " + x.Password));
            Console.WriteLine();

            int adminCount = exercise.CountAdmins(users);
            Console.WriteLine("Number of Admins: {0}", adminCount);
            Console.WriteLine();

            List<User> firstTwoUsers = exercise.FirstTwoUsers(users);
            exercise.ShowUsers(firstTwoUsers, "---First Two Users---");

            User newestUser = exercise.NewestUser(users);
            exercise.ShowUsers(new List<User>() { newestUser }, "---Newest User---");

            User minIdUser = exercise.NewestUser(users);
            exercise.ShowUsers(new List<User>() {minIdUser}, "---User with Minimum Id---");

            User lookedForUser = exercise.FindByObject(users, minIdUser);
            exercise.ShowUsers(new List<User>() { lookedForUser }, "---Looked For User---");

            /*Display Info on Objects*/
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
