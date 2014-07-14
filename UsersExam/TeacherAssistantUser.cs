using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersExam;

namespace UsersExam
{
    class TeacherAssistantUser : User
    {
        public TeacherUser AssignedTeacher { get; set; }
        private IExamDelegate examBehaviour;

        public TeacherAssistantUser(string username, string password, int id, TeacherUser assignedTeacher) : base(username, password, id)
        {
            this.AssignedTeacher = assignedTeacher;
            examBehaviour = new ExamTakingTeacherAssistantUser();
        }

        public override string Login()
        {
            return String.Format("Teacher assistant {0} has logged in.", username);
        }

        public override string Logout()
        {
            return String.Format("Teacher assistant {0} has logged out.", username);
        }

        public string TakeExam()
        {
            return examBehaviour.TakeExam();
        }
    }
}
