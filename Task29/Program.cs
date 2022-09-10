// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int[] arr = new int[8];

void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++) 
    {
        array[i] = new Random().Next(0, 100);
        if (i == count-1) Console.Write($"{array[i]} -> ");
        else Console.Write($"{array[i]}, ");
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i == count-1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

FillArray(arr);
PrintArray(arr);