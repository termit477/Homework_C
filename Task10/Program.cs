// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трехзначное натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99) && (number < 1000))
{
    int result = number / 10 % 10;
    Console.WriteLine(result);
}
else if ((number < -99) && (number > -1000))
{
    int result = -(number / 10 % 10);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ натуральное число");
}
