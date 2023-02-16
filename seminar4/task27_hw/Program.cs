// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int SumNumbers(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += n%10;
        n /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {N} равна {SumNumbers(N)}");