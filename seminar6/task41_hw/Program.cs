// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetPositive(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите количество генерируемых чисел: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, -30, 30);

Console.Write(String.Join(", ", array));
Console.Write(" -> ");
Console.Write(String.Join(", ", GetPositive(array)));
Console.WriteLine();
