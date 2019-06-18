using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class Manager : Employee
    {
        public long AnnualSalary { get; set; }
        public long QuaterlyBonus { get; set; }
        public override long GetMonthlySalary()
        {
            return (AnnualSalary / 12) + (QuaterlyBonus/4);
        }
    }
}
