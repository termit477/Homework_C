// Написать программу, которая на вход принимает число, а на выходе показывает все четные числа от 1 до N

Console.Clear();

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (num > 0)
{
    while (count <= num)
    {
    Console.Write($"{count} ");
    count += 2;
    }
}
else 
{
    Console.Write("Введите ПОЛОЖИТЕЛЬНОЕ натуральное число");
}