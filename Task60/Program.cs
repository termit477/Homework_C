// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    int number = 0;

    for (int i = 0; i < size; i++)
    {
        if (i == 0) arr[0] = rnd.Next(min, max + 1);
        else
        {
            bool repeat = true;
            while (repeat == true)
            {
                number = rnd.Next(min, max + 1);
                int count = 0;
                {
                    for (int j = 0; j < i; j++) if (number != arr[j]) count++;
                    if (count == i)
                    {
                        arr[i] = number;
                        repeat = false;
                    }
                }
            }
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
    Console.WriteLine();
}

int[,,] CreateMatrix(int rows, int collumns, int depth, int[] arr)
{
    int[,,] matr = new int[rows, collumns, depth];
    int count = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = arr[count];
                count++;
            }
        }
    }
    return matr;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k],3}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] array = CreateArray(8, 10, 99);
PrintArray(array);

int[,,] matrix = CreateMatrix(2, 2, 2, array);
PrintMatrix(matrix);

