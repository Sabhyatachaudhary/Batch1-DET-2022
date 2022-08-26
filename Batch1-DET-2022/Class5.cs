using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo1
{
    internal class TestCircle
    {
        public static void Main()
        {
            circle c = new circle(2);
            double result = c.area();
            Console.WriteLine($"area of circle {result}");

        }
    }
}
