Console.WriteLine("Введите число");
string num = Console.ReadLine();
int iNum = int.Parse(num);
Console.WriteLine($"От 1 до {iNum} следующие числа четные:");
for (int i = 1; i <= iNum; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}
