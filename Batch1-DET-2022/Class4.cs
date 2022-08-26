using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo1
{
    internal class circle
    {
        double Radius;
        public circle(double radius)
        {
            this.Radius = radius;
        }
        public double area()
        {
            return Math.PI * Radius * Radius;

        }
    }
}

