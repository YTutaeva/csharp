// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void CountMinimalSummInRow(int[,] Array)
{
    int MinimalRowSumm = 0;
    int tempSumm = 0;
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            tempSumm = tempSumm + Array[i, j];
        }
            {
                if (MinimalRowSumm == 0)
                {
                    MinimalRowSumm = tempSumm;
                }
                if (tempSumm < MinimalRowSumm)
                {
                    MinimalRowSumm = tempSumm;
                }
            }
                    tempSumm = 0;
    }
                Console.WriteLine(@"Минимальная строчная сумма массива = {0}",  MinimalRowSumm);
}


Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int column = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, column, 0, 20);
PrintArray(array2D);

Console.WriteLine();
CountMinimalSummInRow(array2D);

Console.WriteLine();