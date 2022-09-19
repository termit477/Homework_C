// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();

Console.Write("Введите количество вводимых элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size1)
{
    int[] array = new int[size1];
    for (int i = 0; i < size1; i++)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        array[i] = a;
    }
    return array;
}

int PositiveNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}

int[] arr = CreateArray(size);
int result = PositiveNumber(arr);
Console.WriteLine($"Количество положительных чисел: {result}");