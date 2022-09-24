// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] FindArithmeticMean(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];
    arr[0] = 0;
    int index = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            if (i < matr.GetLength(0) - 1) arr[index] += matr[i, j];
            if (i == matr.GetLength(0) - 1)
            {
                arr[index] = (arr[index] + matr[i, j]) / matr.GetLength(0);
                index++;
            }
        }
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"Среднее арифметическое каждого столбца: {arr[i]} | ");
        else if (i < arr.Length - 1) Console.Write($"{arr[i]} | ");
        else Console.WriteLine($"{arr[i]}");
    }
    Console.WriteLine();
}

int[,] matrix = CreateMatrix(5, 5, 0, 9);
PrintMatrix(matrix);

double[] array = FindArithmeticMean(matrix);
PrintArray(array);