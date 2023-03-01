// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("При введении m = 3 - не вводите n больше 4, это вызовет переполнение стека. При введении m = 4 - не вводите n больше 0 - это тоже вызовет переполнение стека. ");
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetAckermann(m, n));

int GetAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return GetAckermann(m - 1, 1);
    }
    else 
    {
        return GetAckermann(m - 1, GetAckermann(m, n - 1));
    }
}