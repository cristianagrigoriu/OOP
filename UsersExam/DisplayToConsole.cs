using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class DisplayToConsole : IDisplayInfo
    {
        public void DisplayInfo(string output)
        {
            Console.WriteLine(output);
        }
    }
}
