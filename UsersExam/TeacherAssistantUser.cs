using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersExam;

namespace UsersExam
{
    class TeacherAssistantUser : User, IExamTakingUser
    {
        public TeacherUser AssignedTeacher { get; set; }

        public TeacherAssistantUser(string username, string password, int id, TeacherUser assignedTeacher) : base(username, password, id)
        {
            this.AssignedTeacher = assignedTeacher;
        }

        public void TakeExam()
        {
            SuperviseStudents();
            GradeStudents();
        }

        private void GradeStudents()
        {
            Console.WriteLine("Teacher assistant {0} is grading students.", username);
        }

        private void SuperviseStudents()
        {
            Console.WriteLine("Teacher assistant {0} is supervising students.", username);
        }
    }
}
