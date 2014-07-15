using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ExamTakingTeacherAssistantUser : User, IExamDelegate
    {
        private IDisplayInfo df;

        public void TakeExam(int option, string name)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            df = c.CreateDisplay(option);

            SuperviseStudents(name);
            GradeStudents(name);
        }

        private void GradeStudents(string name)
        {
            df.DisplayInfo("Teacher assistant " + name + " is grading students.");
        }

        private void SuperviseStudents(string name)
        {
            df.DisplayInfo("Teacher assistant " + name + " is supervising students.");
        }
    }
}
