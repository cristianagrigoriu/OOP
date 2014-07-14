using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    class ConcreteDisplayInfo : IAbstractDisplayInfo
    {
        public IDisplayInfo CreateDisplayInfoToFile()
        {
            return new DisplayToFile();
        }

        public IDisplayInfo CreateDisplayInfoToConsole()
        {
            return new DisplayToConsole();
        }
    }
}
