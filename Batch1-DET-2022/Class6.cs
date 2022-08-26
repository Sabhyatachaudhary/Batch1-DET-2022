using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo1
{
    internal class employee
    {
        int rollno;
        char name;
        int address;
        int pin_code;
        int phone_number;
        int pf;
        int grosssal;
        public employee(int rollno, string name, int address, int pin_code, int phone_number)
        {

            this.rollno = rollno; name = name; this.address = address; this.pin_code = pin_code; this.phone_number = phone_number;
        }
        public double GetNetSalary()
        {
            pf = 12 * grosssal / 100;
            int netsalary = grosssal - pf;
            return netsalary;

        }
    }
}
