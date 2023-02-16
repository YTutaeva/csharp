// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер дня недели от 1-7: ");

int weekday = int.Parse(Console.ReadLine()!);

if (weekday == 6 || weekday == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}