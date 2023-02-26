// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Работаем

int rows = 5;
int columns = 4;
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Строка с индексом {GetSumRows(array)} имеет наименьшую сумму элементов.");

// Методы

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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

int GetSumRows(int[,] arr)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minSum += arr[0,i];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (minSum>sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}