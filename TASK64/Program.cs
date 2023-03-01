// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"N = {N} -> [ ");
GetDigitsFromNto1(N);

void GetDigitsFromNto1(int number)
{
    if (number - 1 == 0)
    {
        Console.Write($"{number} ]");
    }
    else
    {
        Console.Write($"{number}, ");
        GetDigitsFromNto1(number - 1);
    }
}