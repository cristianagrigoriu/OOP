using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ExamTakingTeacherUser : User, IExamDelegate
    {
        private IDisplayInfo df;

        public void TakeExam(int option, string name)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            df = c.CreateDisplay(option);

            PrepareQuestions(name);
            SuperviseStudents(name);
            GradeStudents(name);
        }

        private void GradeStudents(string name)
        {
            df.DisplayInfo("Teacher " + name + " is grading students.");
        }

        private void SuperviseStudents(string name)
        {
            df.DisplayInfo("Teacher " + name + " is supervising students.");
        }

        private void PrepareQuestions(string name)
        {
            df.DisplayInfo("Teacher " + name + " is preparing questions.");
        }
    }
}
