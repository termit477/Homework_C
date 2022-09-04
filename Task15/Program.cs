// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 0) && (number < 8))
{
    if ((number == 6) || (number == 7))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}