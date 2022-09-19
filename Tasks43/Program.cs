// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();

Console.WriteLine("Введите координаты первой прямой");
Console.Write("k: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй прямой");
Console.Write("k: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
double b2 = Convert.ToInt32(Console.ReadLine());

void CheckingLines(double a1, double b1, double a2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"x = {x}, y = {y}");
    }
}

CheckingLines(k1, b1, k2, b2);