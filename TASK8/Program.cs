﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
int current = N--;
while (current > 1)
{
if (current % 2 == 0)
{
    Console.WriteLine(current);
    current--;
}
else
{
    current--;
}
}