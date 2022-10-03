// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int FuncAccerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if ((num1 != 0) && (num2 == 0)) return FuncAccerman(num1 - 1, 1);
    if ((num1 > 0) && (num2 > 0)) return FuncAccerman(num1 - 1, FuncAccerman(num1, num2 - 1));
    return FuncAccerman(num1, num2);
}
int accerman = FuncAccerman(m, n);
Console.WriteLine(accerman);
