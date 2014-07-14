using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ExamNotTakingUser : User, IExamDelegate
    {
        public void TakeExam()
        {
            //"Does Not Take Exam!";
        }
    }
}
