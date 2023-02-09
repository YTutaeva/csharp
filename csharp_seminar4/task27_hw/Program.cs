// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfNumber(int Number);
{
    int sum = 0;
    int Number = 0;
    
    for (int i = 1; i <= Number; i++)
    {
        sum += i;
    }
    return sum;
}
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {N} равна {SumOfNumber(N)}");