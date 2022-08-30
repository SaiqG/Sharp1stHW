Console.WriteLine("Введите три числа");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
string num3 = Console.ReadLine();
var iNum1 = int.Parse(num1);
var iNum2 = int.Parse(num2);
var iNum3 = int.Parse(num3);

int max = iNum1;

if ( max < iNum2)
{
max = iNum2;
}
if ( max < iNum3)
{
    max = iNum3;
}
Console.WriteLine($"{max} тут самое большое");
