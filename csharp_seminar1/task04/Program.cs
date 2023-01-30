// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.Clear();

Console.Write("Введите число а ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число c ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (b > max)max=b;
if (c > max)max=c;

Console.WriteLine($"{max}");