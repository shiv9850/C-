using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public String LastName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public abstract long GetMonthlySalary();
        

    }
}
