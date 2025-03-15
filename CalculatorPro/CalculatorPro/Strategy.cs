using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPro
{
    // родоначальник стратегий
    internal interface ICount
    {
        double DoCount(double num1, double num2);
    }
}
