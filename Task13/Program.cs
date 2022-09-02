// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number > 999)
{
    while (number > 999)
    {
        number /= 10;
        if ((number > 99) && (number < 1000))
        {
            result = number % 10;
            Console.WriteLine(result);
        }
    }
}
else 
{
    result = number % 10;
    Console.WriteLine(result);
}