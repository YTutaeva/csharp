﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue);
    }
    return Result;
}

int GetSum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
    
}
void WriteOnScreen(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] array = GetArray(4, -8, 34);
WriteOnScreen(array);
Console.WriteLine();

int Numbers = GetSum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {Numbers}");

Console.WriteLine();