// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.

Console.Clear();

double ResultX(int b1, int k1, int b2, int k2)
{
    double x1 = b2 - b1;
    double x2 = k1 - k2;
    double x = x1 / x2;
    return x;
}

double ResultY(int k1, int b1, double x)
{
    double y = (k1 * x) + b1;
    return y;
}

Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);

double x = ResultX(b1, k1, b2, k2);
double y = ResultY(k1, b1, x);

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> (x; {y}.");
