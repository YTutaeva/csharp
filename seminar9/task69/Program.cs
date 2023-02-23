// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

Console.Clear();

int Sqr (int A, int B)
{
    if (B == 0) return 1;
    return Sqr (A, B - 1) * A;
}
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(Sqr(A,B));
