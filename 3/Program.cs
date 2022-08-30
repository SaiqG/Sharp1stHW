Console.WriteLine("Введите число");
string num1 = Console.ReadLine();
var iNum1 = int.Parse(num1);
if (iNum1 % 2 == 0)
{
    Console.WriteLine($"{num1} четное");
}
else
{
    Console.WriteLine($"{num1} не четное");
}
