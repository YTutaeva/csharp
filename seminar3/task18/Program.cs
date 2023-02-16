// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
 
 Console.Write("Введите номер четверти ");
 int quarter = int.Parse(Console.ReadLine()!);


 if (quarter == 1)
 {
    Console.Write("Координаты четверти X>0 , Y>0 ");
 }
 else if (quarter == 2)
 {
    Console.Write("Координаты четверти X<0 , Y>0 ");
 }
 else if (quarter == 3 )
 {
    Console.Write("Координаты четверти X<0 , Y<0 ");
 }
 else if (quarter == 4 )
 {
    Console.Write("Координаты четверти X>0 , Y<0 ");
 }
else 
{
    Console.WriteLine("Введите число от 1 до 4 ");
}