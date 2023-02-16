// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
int DigitCount(int A)
{
    int count = 0;
    if (A == 0)
    {
        count = 1;
    }
    else
    {
        while (A != 0)
        {
            A /= 10;
            count++;
        }
    }
    return count;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Количество цифр числа {N} равно {DigitCount(N)}");
