﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    public class PermentEmployee : Employee
    {
        public long AnnualSalary { get; set; }

        public override long GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }
    }
}
