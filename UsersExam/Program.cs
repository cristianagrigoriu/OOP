using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            stud1.Login();
            prof2.Logout();

            stud1.TakeExam();
            prof2.TakeExam();
            ass1.TakeExam();
        }
    }
}
