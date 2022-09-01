// Написать программу, которая на вход принимает число и выдает, является ли число четным

Console.Clear();

Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
Console.Write($"Ваше число {num} является четным");
}
else 
{
Console.Write($"Ваше число {num} является нечетным");
}