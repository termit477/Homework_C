// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести число: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= degree; i++)
{
    result *= number;
}
Console.WriteLine($"{number}, {degree} -> {result}");