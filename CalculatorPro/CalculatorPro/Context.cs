using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPro
{
    class Calc
    {
        // ну тут тупо контекст
        private ICount? _count;
        public void SetCalc(ICount count) 
        { 
            _count = count;
        }

        public double DoCalc(double num1, double num2)
        {
            if (_count is null)
            {
                Console.WriteLine("Чего???");
                throw new Exception();
            }

            return _count.DoCount(num1, num2);
        }
    }
}
