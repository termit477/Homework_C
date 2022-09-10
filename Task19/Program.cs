// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number < 0) number = -number;

if ((number > 9999) && (number < 100000))
{
    int n1 = number / 10000;
    int n2 = number / 1000 % 10;
    int n3 = number / 100 % 10;
    int n4 = number / 10 % 10;
    int n5 = number % 10;
    result = n5 * 10000 + n4 * 1000 + n3 * 100 + n2 * 10 + n1;

    if (result == number) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Введите другое число");
