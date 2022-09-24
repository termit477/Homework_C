// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateMatrix(int rows, int collumns, int min, int max)
{
    double[,] matrix = new double[rows, collumns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"|{matr[i, j],4} ");
            else Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите параметры матрицы.");
Console.Write("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = CreateMatrix(m, n, 0, 10);
PrintMatrix(matrix);