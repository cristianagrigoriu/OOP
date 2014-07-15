using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ExamNotTakingUser : User, IExamDelegate
    {
        private IDisplayInfo df;

        public void TakeExam(int option, string name)
        {
            ConcreteDisplayFactory c = new ConcreteDisplayFactory();
            df = c.CreateDisplay(option);

            df.DisplayInfo("User " + name + " does not take exam!");
        }
    }
}
