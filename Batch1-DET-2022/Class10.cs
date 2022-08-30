using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    internal interface ICar
    {
        int GetPrice(string name);
    }
    class BMW : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "m3")
                return 130000;
            else if (name == "x7")
                return 960000;
            else
                return 100000;
        }
    }
}
