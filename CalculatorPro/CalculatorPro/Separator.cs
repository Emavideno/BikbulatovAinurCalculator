using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPro
{
    internal class Separator
    {
        // метод ниже позволяет вводить как через пробел, так и без него
        public static List<string> SeparateNums(string str)
        {
            List<string> numsOpers = [];
            StringBuilder sb = new StringBuilder();    // StringBuilder, чтобы память не засорять
            sb.Append(str);
            string[] opers = ["+", "-", "*", "/"];

            foreach (string oper in opers)
            {
                AddSpaces(oper, sb);
            }

            sb.Replace("  ", " ");    // в слечае, если пользователь захотел ввести с пробелами
            string unsepStr = sb.ToString();
            string[] sepStr = unsepStr.Split(' ');
            foreach (string sep in sepStr)
            {
                numsOpers.Add(sep);
            }
            return numsOpers;
        }

        // добавляет пробелы, чтобы потом по ним разделить
        public static void AddSpaces(string oper, StringBuilder sb)
        {
            sb.Replace(oper, $" {oper} ");
        }
    }
}
