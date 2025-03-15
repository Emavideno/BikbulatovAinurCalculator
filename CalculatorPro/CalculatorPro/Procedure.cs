using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPro
{
    internal class Procedure
    {
        // метод ниже определяет нужную приоритетную операцию и зпускает её
        public static List<string> DoProcedure(List<string> sepStr)
        {
            char oper;
            
            Calc calc1 = new Calc();
            while (sepStr.Contains("*") || sepStr.Contains("/"))
            {
                int mulIndex = sepStr.IndexOf("*");
                int divIndex = sepStr.IndexOf("/");

                if (mulIndex == -1)
                    mulIndex = 999999;   // треклятый IndexOf принимает -1, если не найдено
                if (divIndex == -1)
                    divIndex = 999999;

                if (mulIndex < divIndex)
                {
                    oper = '*';
                    PreCalc(oper, mulIndex, sepStr);
                }
                else
                {
                    oper = '/';
                    PreCalc(oper, divIndex, sepStr);
                }
            }
            return sepStr;
        }

        // метод ниже считает приоритетную операцию, и удаляет из списка остаточную инфу(2 * 3 делает просто 6)
        public static void PreCalc(char oper, int operIndex, List<string> sepStr)
        {
            Calc calc1 = new Calc();
            double num1 = double.Parse(sepStr[operIndex - 1]);
            double num2 = double.Parse(sepStr[operIndex + 1]);

            if (oper == '*')    // наверное можно было каким-то образом интерфейс сразу в метод передать, но я не понял как
                calc1.SetCalc(new Multi());
            else
                calc1.SetCalc(new Divide());

            sepStr[operIndex - 1] = (calc1.DoCalc(num1, num2)).ToString();

            sepStr.RemoveRange(operIndex, 2);    // Убирает лишний знак и число
        }
    }
}
