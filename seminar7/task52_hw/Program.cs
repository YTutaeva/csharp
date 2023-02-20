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


string FindArifmeticAverage(int[,] inArray2d)
{
    string result = "Среднее арифметическое каждого столбца: ";
    double sum;
    double average;
    for (int i = 0; i < inArray2d.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray2d.GetLength(0); j++)
        {
            sum += inArray2d[j, i];
        }
        average = sum / inArray2d.GetLength(0);
        result += $"{average:f1}";
        if (i != inArray2d.GetLength(1) - 1) result += "; ";
        else result += ".";
    }
    return result;

}

Console.Clear();

Console.Write("Введите число строк в двумерном массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов в двумерном массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(rows, columns, 1, 10);
PrintArray(array2D);
Console.WriteLine(FindArifmeticAverage(array2D));