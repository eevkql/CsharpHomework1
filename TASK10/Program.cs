// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите целое трехзначное число: ");
int n = int.Parse(Console.ReadLine());
if (n >= 100 && n < 1000)
{
    n = n/10;
    n = n%10;
    Console.WriteLine(n);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным или не является целым, введите другое число.");
}