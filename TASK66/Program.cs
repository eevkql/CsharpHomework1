// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число (оно должно быть меньше второго): ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число (оно должно быть больше второго): ");
int N = int.Parse(Console.ReadLine()!);
int sum = 0;
GetSumDigits(M, N);

void GetSumDigits(int first, int last)
{
    if (first == last + 1)
    {
        Console.Write($"N = {first - 1} -> {sum}");
    }
    else
    {
        sum += first;
        GetSumDigits(first + 1, last); //4+5+6+7+8
    }
}
