// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("ax = ");
long x1 = long.Parse(Console.ReadLine());
Console.WriteLine("bx = ");
long x2 = long.Parse(Console.ReadLine());
Console.WriteLine("ay = ");
long y1 = long.Parse(Console.ReadLine());
Console.WriteLine("by = ");
long y2 = long.Parse(Console.ReadLine());
Console.WriteLine("az = ");
long z1 = long.Parse(Console.ReadLine());
Console.WriteLine("bz = ");
long z2 = long.Parse(Console.ReadLine());
double d;                                     //Distance
d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
d = Math.Round(d,2);
Console.WriteLine($"Расстояние между двумя точка A и B = {d}");
