Console.WriteLine("Введите два числа");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
var iNum1 = int.Parse(num1);
var iNum2 = int.Parse(num2);
if (iNum1 > iNum2)
{
    Console.WriteLine("Первое число больше");
}
else if (iNum1 < iNum2)
{
    Console.WriteLine("Второе число больше");
}
else
{
    Console.WriteLine("Числа равны");
}