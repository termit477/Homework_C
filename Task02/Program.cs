// Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
Console.Write($"Наибольшее число равно {num1}, а наименьшее равно {num2}");
}
else 
{
Console.Write($"Наибольшее число равно {num2}, а наименьшее равно {num1}");
}