// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Работаем
Console.Clear();
double[] arr = GetArray(4);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine($"Разница = {GetDif(arr)}");

// Методы
double[] GetArray(int size)
{
    double[] res = new double[size];
    int index = 0;
    while (index < size)
    {
        res[index] = new Random().NextDouble() * 10;
        index++;
    }
    return res;
}

double GetDif(double[] array)
{
    double min = 0;
    double max = 0;
    foreach (var el in array)
    {
        if (min > el) min = el;
        if (max < el) max = el;
    }
    return max - min;
}