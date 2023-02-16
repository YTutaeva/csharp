// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран.

int[] GetArray(int size)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(5, 98);
    }
    return Result;
}

void WriteOnScreen(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}

int[] array = GetArray(8);
WriteOnScreen(array);
Console.WriteLine();