using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        string GetPrice();
    }
   
   class BMW :ICar
    {
        public string Name { get; set; }
        public int price { get; set; }
    }

}
