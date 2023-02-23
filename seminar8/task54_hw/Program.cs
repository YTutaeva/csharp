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

void SortDescendinginRows(int[,] sortArray)
{
    for (int i = 0; i < sortArray.GetLength(0); i++)
    { 
        for (int j = 0; j < sortArray.GetLength(1); j++)  
        {
            int buff = 0;
            if(sortArray[i,j] < sortArray[i,j+1])
            {
                buff = sortArray[i, j];
                sortArray[i, j] = sortArray[i,j+1];
                sortArray[i, j] = buff;
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
SortDescendinginRows(array2D);
PrintArray(array2D);