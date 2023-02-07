// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write(GetSum(n));

int GetSum(int number)
{
    int sum = 0;
    int m = 0;
    while (number > 0)
    {
        m = number%10;
        sum = sum + m;
        number = number / 10;
    }
    return sum;
}