using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class HolidayEventScenario
    {
        public void showScenario()
        {
            Hierarchy h = new Hierarchy();
            List<Employee> people = h.CreateHierarchy();

            people[1].LeavesOnHoliday(3);
            h.showHierarchy(people, "On Holiday");

            people[1].ReturnsFromHoliday(3);
            h.showHierarchy(people, "Holiday Over");
        }
    }
}
