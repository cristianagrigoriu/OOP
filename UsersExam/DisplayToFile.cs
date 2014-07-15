using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class DisplayToFile : IDisplayInfo
    {
        public void DisplayInfo(string output)
        {
            System.IO.File.AppendAllText(@"C:\Users\cristiana.grigoriu\My Documents\WriteText.txt", output + Environment.NewLine);
        }
    }
}
