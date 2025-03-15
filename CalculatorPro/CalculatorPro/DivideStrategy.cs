using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPro
{
    class Divide : ICount
    {
        // стратежка
        public double DoCount(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            Console.WriteLine("На ноль куда делишь лее");
            Console.WriteLine("401 1505");
            throw new NotImplementedException();
        }
    }
}
