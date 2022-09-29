// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    if ((matr1.GetLength(0) != matr2.GetLength(0)) || (matr1.GetLength(1) != matr2.GetLength(1))) Console.WriteLine("Матрицы нельзя перемножить");
    else 
    {
        int[,] res = new int[matr1.GetLength(0), matr2.GetLength(1)];

        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                for (int k = 0; k < res.GetLength(0); k++)
                {
                    res[i,j] += matr1[i,k] * matr2[k,j];
                }
            }
        }
        PrintMatrix(res);
    }
}

int[,] matrix1 = CreateMatrix(2, 2, 0, 9);
PrintMatrix(matrix1);

int[,] matrix2 = CreateMatrix(2, 2, 0, 9);
PrintMatrix(matrix2);

MultiplicationMatrix (matrix1,matrix2);