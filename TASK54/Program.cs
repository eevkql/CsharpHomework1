// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Работаем

int rows = 3;
int columns = 4;
int[,] array = GetArray(rows, columns);
PrintArray(array);
SortArray(array);
// PrintArray(array);

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

// void SortArray(int[,] arr)   //I-ый метод сортировки двумерного массива.
// {
//     Console.WriteLine();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(0); j++)
//         {
//             for (int k = 0; k < arr.GetLength(1) - 1; k++)
//             {
//                 if (arr[i, k] < arr[i, k + 1])
//                 {
//                     int temp = arr[i, k + 1];
//                     arr[i, k + 1] = arr[i, k];
//                     arr[i, k] = temp;
//                 }
//             }
//         }
//     }
// }


// void SortArray(int[,] arr)  //II-ой метод сортировки массива НЕ РАБОТАЕТ, ДОДЕЛАТЬ.
// {
//     Console.WriteLine();
//     int[] rowarr = new int[arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         for (int j = 0; j < arr.GetLength(0); j++)
//         {
//             Array.Sort(rowarr);
//             Array.Reverse(rowarr);
//             Console.Write(rowarr[i]);
//         }
//     }
// }