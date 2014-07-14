using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseShowCollections();

            ExerciseObservers();
        }

        private static void ExerciseObservers()
        {
            /* Go On Holiday Event */
            HolidayEventScenario s = new HolidayEventScenario();
            s.showScenario();
        }

        private static void ExerciseShowCollections()
        {
            /* Hierarchy */
            Hierarchy h = new Hierarchy();
            List<Employee> people = h.CreateHierarchy();

            /* Collections */
            Collections c = new Collections();
            c.CreateCollections();
        }
    }
}

