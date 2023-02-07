// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());                                           
if (B > 0)
{
    Console.WriteLine(Math.Pow(A, B));
}
if (B < 0)
{
    B*=-1;
    Console.WriteLine($"1/{(Math.Pow(A, B))}");
}
else if (B == 0)
{
    Console.WriteLine(A / A);
}