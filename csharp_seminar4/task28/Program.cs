// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.Clear();

int Multi(int number)
{
    int prod = 1;

    for (int i = 2; i <= number; i++)
    {
        prod *= i; // prod = prod * i
    }
    return prod;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Произведения чисел от 1 до {N} равно {Multi(N)}");