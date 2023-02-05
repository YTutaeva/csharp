// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

while (number >= 9999 || number < 99999)
{
    Console.Write("Введите пятизначное число: ");
    int number = int.Parse(Console.Readline()!);
}

if (number > 9999 || number <= 99999)
{
num1 = number * 100;
num2 = number % 10 + number % 100;

    if (num1 == num 2)
    {
    Console.WriteLine("да");
    }
    else
    {
    Console.WriteLine("нет");
    }
}
