// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m, int n, int minValue, int maxValue)

{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] Array)
{
    bool IsSorted = true;
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (IsSorted == false)
            {   
                if (i != 0)
                {
                    i = i - 1;
                    IsSorted = true;
                }
            }
            if (j != Array.GetLength(1)-1)
            {
                if (Array[i, j] < Array[i, j + 1])
                {
                    int buff = Array[i, j];
                    Array[i, j] = Array[i, j + 1];
                    Array[i, j + 1] = buff;
                    IsSorted = false;
                }
            }
        }
    }
}

Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int column = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, column, -10, 10);
PrintArray(array2D);

Console.WriteLine();
SortArray(array2D);
PrintArray(array2D);