// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int FindArifmeticAverage(int[,] array2d)
{
    int result = 0;
    j = 0;
    for (int i = 0; i <= j; j+1)
    {
        result += array2d[i, j] + array2d[i, j+1] + array2d[i, j+2]
    }
    return result;
}

Console.Clear();

int[,] myArray = GetArray(3, 4, 1, 9);
PrintArray(myArray);
int result = FindArifmeticAverage(myArray);
Console.WriteLine();
Console.WriteLine(result);