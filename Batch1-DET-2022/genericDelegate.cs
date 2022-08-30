using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    class genericDelegate
    {
        public static void Main()
        {
            Action<string, string> helo = (string name, string loc) =>
            {
                Console.WriteLine("hello" + name + "from" + loc);
            };
            helo("mary", "gv1");
            Func<int, int, long> multiply = (x, y) =>
            {
                return x * y;
            };
            long result = multiply(100, 100);
            Console.WriteLine(result);

        }
        static void Hi(string name)
        {
            Console.WriteLine("Hai" + name);
        }
    }
}
