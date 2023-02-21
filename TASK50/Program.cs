// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.


// Работаем

int rows = 3;
int columns = 4;
int[,] array = GetArray(rows, columns);
PrintArray(array);

Console.WriteLine("Введите индекс строки элемента: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс столбца элемента: ");
int n = int.Parse(Console.ReadLine()!);
GetElement(array, m, n);

// Методы

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetElement(int[,] arr, int m, int n)
{
    if (m <= arr.GetLength(0) && n <= arr.GetLength(1))
    {
        Console.WriteLine($"Введенный индекс указывает на число: {arr.GetValue(m, n)}");  
    }
    else
    {
        Console.WriteLine($"По введенному индексу [{m},{n}] элемент не найден. ");
    }
}
