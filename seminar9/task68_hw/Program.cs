﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int AkkermanFunction(int m, int n)
{
    if (m ==0 ) 
    {
        return n+1;
    }
    else if (n == 0 && m >0) 
    {
        return AkkermanFunction(m-1,1);
    }
    else 
    {
        return (AkkermanFunction(m-1, AkkermanFunction(m,n-1)));
    }
}

void Akkerman (int m, int n)
{
    Console.Write(AkkermanFunction(m,n));
}

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Akkerman(m,n);

Console.WriteLine();

