using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPro
{
    class Minus : ICount
    {
        // стратежка
        public double DoCount(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
