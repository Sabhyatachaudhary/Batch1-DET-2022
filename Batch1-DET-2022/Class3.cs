using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo1
{
    internal class Class3
    {
        public static void Main()
        {
            Emp e = new Emp(5050, "Mary", new DateOnly(2020, 8, 1));
            Console.WriteLine($"years of exceptons{e.GetYearsofExp()}");
        }
    }
}