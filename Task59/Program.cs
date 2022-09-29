// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] FindMin(int[,] matr)
{
    int[] newArray = new int[2];
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
                newArray[0] = i;
                newArray[1] = j;
            }
        }
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[,] DeleteString(int[,] matr, int[] mi)
{
    int[,] newMatr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ((mi[0] > i) && (mi[1] > j)) newMatr[i, j] = matr[i, j];
            if ((mi[0] > i) && (mi[1] < j)) newMatr[i, j - 1] = matr[i, j];
            if ((mi[0] < i) && (mi[1] > j)) newMatr[i - 1, j] = matr[i, j];
            if ((mi[0] < i) && (mi[1] < j)) newMatr[i - 1, j - 1] = matr[i, j];
        }
    }
    return newMatr;
}

int[,] matrix = CreateMatrix(4, 4, 0, 99);
PrintMatrix(matrix);

int[] min = FindMin(matrix);
PrintArray(min);

int[,] result = DeleteString(matrix, min);
PrintMatrix(result);