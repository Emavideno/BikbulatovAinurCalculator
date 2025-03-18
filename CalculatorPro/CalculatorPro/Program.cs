using CalculatorPro;

Console.Write("Введите выражение: ");
string inputStr = Console.ReadLine();

// Ниже будет немного тесткейсов, просто раскомментируйте и закомментируйте 2 строки выше
string inputStr = "8 / 3 +6/3*2 + 1,5";    // Ответ: 8,167
//string inputStr = "3/1+12/2*8+8*3-21";    // Ответ: 54
//string inputStr = "5 + 3,2 - 1,5 * 2 / 0,5 + 7";    // Ответ: 9,2  
//string inputStr = "10-2,5*3+4,8 /                  1,2-0,75";    // Ответ: 5,75

List<string> SepStr = Separator.SeparateNums(inputStr);
while (SepStr.Contains(""))    // Если пользователь ввёл несколько пробелов
{
    SepStr.Remove("");
}

List<string> preCalcList = Procedure.DoProcedure(SepStr);

Calc calc = new Calc();
while (SepStr.Count > 1)
{
    string oper = SepStr[1];
    double num1 = double.Parse(SepStr[0]);
    double num2 = double.Parse(SepStr[2]);

    switch (oper)
    {
        case "+":
            calc.SetCalc(new Plus());
            break;
        case "-":
            calc.SetCalc(new Minus());
            break;
        case "*":
            calc.SetCalc(new Multi());
            break;
        case "/":
            calc.SetCalc(new Divide());
            break;
        default:
            Console.WriteLine("В данный момент мы не поддерживаем такую операцию");
            return;
    }
    SepStr[0] = (calc.DoCalc(num1, num2)).ToString();
    SepStr.RemoveRange(1, 2);    // убирает лишний знак и число
}
var result = double.Parse(SepStr[0]);
Console.Write("Результат: ");
Console.WriteLine(Math.Round(result, 3));
