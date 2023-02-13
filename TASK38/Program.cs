// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Инициализация
int[] arr = new int [4];

// Работаем
Console.Clear();
GetArray(arr);
PrintArray(arr);
GetMinMax(arr);
GetDif(arr);

// Методы
void GetArray(int[] array)
{
    // while (index < array.Length)
    // {
    // }
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(1,100);
        index++;
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    int position = 0;
    while (position < array.Length)
    {
        Console.Write($"{array[position]}, ");
        position++;
    }
    Console.Write("]");
    Console.WriteLine();
}

double GetMinMax(int[] array)
{
    int min = 0;
    int max = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (min < array[i])
        {
            int min = i;
            i++;
        }
        if (max < array[i])
        {
            int max = 
        }
    }
}

double GetDif(int[] array)
{
    int dif = 0;
    int min = 0;
    int max = 0;
    int i = 0;
    while (i < array.Length)
    {
        
    }
}