// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Enter 1st number: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd number: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("max = " + numberA);
}
else
{
    Console.WriteLine("max = " + numberB);
}