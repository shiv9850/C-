using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class ContractEmployee : Employee
    {
        public int HourlyPay { get; set; }

        public int TotalHours { get; set; }

        public override long GetMonthlySalary()
        {
            return HourlyPay * TotalHours;
        }
    }
}
