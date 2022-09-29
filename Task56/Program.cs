// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] CreateMatrix(int rows, int collumns, int min, int max)
{
    int[,] matrix = new int[rows, collumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"|{matr[i, j],3} ");
            else Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

int[] MatrixToArray(int[,] matr)
{
    int[] arr = new int[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) arr[i] += matr[i, j];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Сумма строки {i} равна: {arr[i]} ");
    }
    Console.WriteLine();
}

int FindMinSum(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[res]) res = i;
    }
    return res;
}

int[,] matrix = CreateMatrix(5, 5, 0, 99);
PrintMatrix(matrix);

int[] array = MatrixToArray(matrix);
PrintArray(array);

int result = FindMinSum(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {result} строка");
Console.WriteLine();