// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

void GenerateXYZArray()
{
    int X = 0;
    int Y = 0;
    int Z = 0;
    int GlobalCounter = 0;
    Console.Write("Введите значение измерения X:   ");
    X = int.Parse(Console.ReadLine()!);
    Console.Write("Введите значение измерения Y:   ");
    Y = int.Parse(Console.ReadLine()!);
    Console.Write("Введите значение измерения Z:   ");
    Z = int.Parse(Console.ReadLine()!);
    int[,,] Array = new int[X, Y, Z];
    int[] UsedNumbers = new int[Array.Length];
    Random Rand = new Random();

    for (int x = 0; x < X; x++)
    {
        for (int y = 0; y < Y; y++)
        {
            for (int z = 0; z < Z; z++)
            {
                bool IsAdded = false;
                while (IsAdded == false)
                {
                    int AddingNubmer = Rand.Next();
                    if (!UsedNumbers.Contains(AddingNubmer))
                    {
                        Array[x, y, z] = AddingNubmer;
                        UsedNumbers[GlobalCounter] = AddingNubmer;
                    }
                        IsAdded = true;
                        GlobalCounter++;
                }
Console.WriteLine( @" Число: {0}     ({1} ; {2} ; {3})", Array[x, y, z], x , y , z);
            }                      
        }
    }
}
GenerateXYZArray();
