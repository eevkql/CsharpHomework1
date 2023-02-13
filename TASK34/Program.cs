// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Инициализация
int[] arr = new int [4];

// Работаем
Console.Clear();
GetArray(arr);
PrintArray(arr);
GetEven(arr);


// Методы
void GetArray(int[] array)
{
    // while (index < array.Length)
    // {
    // }
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(100,1000);
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

int GetEven(int[] array)
{
    int even = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] % 2 == 0)
        {
            even++;
            i++;
            Console.Write($"{even}, ");
        }
        else i++;
    }
    return even;
}
