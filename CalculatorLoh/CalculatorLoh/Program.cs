Console.Write("Введите через пробел(число_знак_число): ");
string str = Console.ReadLine();
string[] numsOper = str.Split();
int num1 = int.Parse(numsOper[0]);
int num2 = int.Parse(numsOper[2]);
string oper = numsOper[1];
if (oper == "+")
    Console.WriteLine(num1 + num2);
else if (oper == "-")
    Console.WriteLine(num1 - num2);
else if (oper == "*")
    Console.WriteLine(num1 * num2);
else
    Console.WriteLine(num1 / num2);
