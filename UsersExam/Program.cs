using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsersExam
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentUser stud1 = new StudentUser("Rachel", "ross", 90, 9);
            StudentUser stud2 = new StudentUser("Ross", "rachel", 100, 12);
            TeacherUser prof1 = new TeacherUser("Monica", "chandler", 3, 900.5, "Cleanliness");
            TeacherUser prof2 = new TeacherUser("Chandler", "monica", 5, 5000.98, "Jokes");
            TeacherAssistantUser ass1 = new TeacherAssistantUser("Phoebe", "princess consuela", 17, prof1);
            TeacherAssistantUser ass2 = new TeacherAssistantUser("Joey", "how you doin'?", 10, prof2);
            AdminUser admin = new AdminUser("Richard", "moustache", 303, "Dentist");
            SecretaryUser sec = new SecretaryUser("Mike", "bag", 304, 20);

            Console.WriteLine(stud1.Login());
            Console.WriteLine(prof2.Logout());

            Console.WriteLine("Choose where you want to display the info: 1 - in the console, 2 - in a file, 0 - to exit.");
            int option = Convert.ToInt32(Console.ReadLine());

            while (option != 0)
            {
                string result = stud1.TakeExam();
                if (option == 1)
                    Console.WriteLine(result);
                if (option ==2)
                    System.IO.File.WriteAllText(@"C:\Users\cristiana.grigoriu\My Documents\WriteText.txt", result);

                Console.WriteLine("Choose where you want to display the info: 1 - in the console, 2 - in a file.");
                option = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.WriteLine(stud1.TakeExam());
            Console.WriteLine(prof2.TakeExam());
            Console.WriteLine(ass1.TakeExam());
        }
    }
}
