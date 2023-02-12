// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(100, 1000);
    }
    return Result;
}

int GetCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
            result++;
    }
    return result;
}

void WriteOnScreen(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}

int[] array = GetArray(8);
WriteOnScreen(array);
Console.WriteLine();

int Numbers = GetCount(array);
Console.WriteLine($"Количество честных чисел в массиве равно {Numbers}");

Console.WriteLine();