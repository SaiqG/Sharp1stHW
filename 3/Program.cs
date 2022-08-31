Console.WriteLine("Введите число");
/*
string num1 = Console.ReadLine();
var iNum1 = int.Parse(num1);
*/
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num} четное");
}
else
{
    Console.WriteLine($"{num} не четное");
}
