using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preventing accidentlt creating instance of Base Class");
            Console.WriteLine("Can force all dericved class for provide implementation of some fuctionality by marking method as abstract");

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Manager");
            Manager manager = new Manager {Id = 1, FirstName = "Adam", LastName = "Muller", AnnualSalary = 120000, QuaterlyBonus = 30000 };
            Console.WriteLine($"{ manager.GetFullName()} has salary {manager.GetMonthlySalary()}");
        }
    }
}
