using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersExam
{
    public interface IAbstractDisplayInfo
    {
        IDisplayInfo CreateDisplayInfoToFile();
        IDisplayInfo CreateDisplayInfoToConsole();
    }
}
