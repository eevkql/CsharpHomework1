// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Инициализация
int[] arr = new int [4];

// Работаем
Console.Clear();
GetArray(arr);
PrintArray(arr);
GetSumOdd(arr);

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

int GetSumOdd(int[] array)
{
    int sumodd = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] % 2 != 0)
        {
            sumodd = sumodd + array[i];
            i++;
        }
        else i++;
    }
    Console.Write($"Сумма нечетных элементов массива = {sumodd} ");
    return sumodd;
}