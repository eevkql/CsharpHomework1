// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Работаем

int rows = 2;
int columns = 2;
int[,] array1 = GetArray(rows, columns);
int[,] array2 = GetArray(rows, columns);
int[,] res = GetMultArrays(array1, array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
Console.WriteLine($"Результат произведения двух матриц: ");
PrintArray(res);

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
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultArrays(int[,] arr1, int[,] arr2)
{
    int rowsArr1 = arr1.GetLength(0);
    int columnsArr2 = arr2.GetLength(1);
    int[,] res = new int[rowsArr1, columnsArr2];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < rowsArr1; i++)
        {
            for (int j = 0; j < columnsArr2; j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    res[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    return res;
}