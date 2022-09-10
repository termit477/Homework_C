// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;

void Square(int a, int b)
{
    while (b <= a)
    {
        Console.WriteLine($"{b,3} | {b * b * b,3}");
        b++;
    }
}

Square(number, index);