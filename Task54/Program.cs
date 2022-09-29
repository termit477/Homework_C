// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 1; j < matr.GetLength(1); j++)
        {
            int count = matr[i, j];
            int k = j;
            while ((k > 0) && (matr[i, k - 1] < count))
            {
                matr[i, k] = matr[i, k - 1];
                k--;
            }
            matr[i, k] = count;
        }
    }
}

int[,] matrix = CreateMatrix(5, 5, 0, 10);
PrintMatrix(matrix);

SortMatrix(matrix);
PrintMatrix(matrix);
