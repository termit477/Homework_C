// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;

int SummMToN(int num1, int num2)
{
    summ += num1;
    if (num1 < num2) SummMToN(num1 + 1, num2);
    else if (num1 > num2) SummMToN(num1 - 1, num2);
    return summ;
}

int sum = SummMToN(m, n);
Console.WriteLine($"Сумма элементов от M до N равна {sum}");
