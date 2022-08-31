Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"От 1 до {num} следующие числа четные:");
for (int i = 2; i <= num; i += 2)
{
    Console.Write($"{i} ");
}
