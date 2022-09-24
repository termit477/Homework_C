// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void FindNumber(int[,] matr, int a, int b)
{
    if ((matr.GetLength(0) - 1 > a) || (matr.GetLength(1) - 1 > b)) Console.WriteLine(matr[a, b]);
    else Console.WriteLine("Такого элемента в массиве нет");
}

int[,] matrix = CreateMatrix(5, 5, 0, 10);
PrintMatrix(matrix);

Console.WriteLine("Введите позиции числа в массиве.");
Console.Write("i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("j: ");
int j = Convert.ToInt32(Console.ReadLine());

FindNumber(matrix, i, j);