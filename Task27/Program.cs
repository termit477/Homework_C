// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 0;

Console.Write(number);

if (number < 0) number = -number;
while (count < number)
{
    result += number % 10;
    number = number / 10;
}

Console.WriteLine($" -> {result}");