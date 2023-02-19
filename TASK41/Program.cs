// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Работаем

Console.Clear();
int[] numbers = new int [100];
EnterArray(numbers);
GetPositive(numbers);


// Методы

void EnterArray(int[] array)
{
    int i = 0;
    int count = 0;
    string br;
    do
    {
        br = Console.ReadLine();
        if (br == "end") break;
        numbers[i] = Convert.ToInt32(br);
        ++i; ++count;
    } while (true);
    Console.WriteLine("Array: ");
    for (int j = 0; j < count; j++)
    {
        Console.Write("{0} ",numbers[j]);
    }
    Console.WriteLine();
}

void GetPositive(int[] array)
{
    int k = 0;
    int res = 0;
    while (k < array.Length)
    {
        if (array[k] > 0)
        {
            res++;
        }
        k++;
    } 
    Console.WriteLine($"Кол-во положительных чисел = {res}"); 
}