// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координаты точки Ax: ");
int Ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Ay: ");
double Ay = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты точки Az: ");
double Az = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координаты точки Bx: ");
int Bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки By: ");
double By = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты точки Bz: ");
double Bz = Convert.ToDouble(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));


Console.WriteLine($"Расстояние между точками А ({Ax}, {Ay}, {Az}) и B ({Bx}, {By}, {Bz}) в 3D пространстве равно {distance:f2}");