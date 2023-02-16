// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num1 = 0;
int num2 = 0;
int num4 = 0;
int num5 = 0;

if (number >= 100000 || number < 10000)
{
    Console.WriteLine("Число не пятизначное, повторите команду и введите пятизначное число ");
}   
    
else if (number > 9999 || number <= 99999)
    {
        num1 = number / 10000;
        num2 = number / 1000 % 10;
        num4 = number % 100 / 10;
        num5 = number % 10;

    if (num1 == num5 && num2 == num4)

        {
            Console.WriteLine($"Число {number} является палиндромом");
        }

    else
        {
            Console.WriteLine($"Число {number} не является палиндромом");
        }

    }



