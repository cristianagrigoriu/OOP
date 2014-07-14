using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{

    public class Employee : Person, IObserverEmployee, ISubjectEmployee
    {
        public Employee Manager { get; set; }
        public DateTime HireDate;
        public bool isOnHoliday { get; set; }
        public List<Employee> Subordinates { get; set; } 

        public Employee() {}

        public Employee(String _firstName, String _lastName, int _age, Genders _gender, Employee _manager, DateTime _hireDate)
            : base (_firstName, _lastName, _age, _gender)
        {
            this.Manager = _manager;
            this.HireDate = _hireDate;
            Subordinates = new List<Employee>();
            Attach();
        }

        public void LeavesOnHoliday(int NumberOfDays)
        {
            this.isOnHoliday = true;
            Notify(NumberOfDays, this.Manager);
        }

        public void ReturnsFromHoliday(int NumberOfDays)
        {
            this.isOnHoliday = false;
            Notify(NumberOfDays, this);
        }

        public void Attach()
        {
            if (this.Manager != null)
                this.Manager.Subordinates.Add(this);
        }

        public void Detach()
        {
            if (this.Manager != null)
                this.Manager.Subordinates.Remove(this);
        }

        public void Notify(int NumberOfDays, Employee SubstituteManager)
        {
            foreach (Employee e in Subordinates)
            {
                e.Update(NumberOfDays, SubstituteManager);
            }
        }

        public void Update(int NumberOfDays, Employee SubstituteManager)
        {
            this.Manager = SubstituteManager;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(" ");
            result.Append(this.HireDate.ToString());
            return result.ToString();
        }
    }
}
