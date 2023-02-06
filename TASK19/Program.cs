// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Enter your number: ");
int n = int.Parse(Console.ReadLine());
int v = n;                                  //v - введенное число.
int reverse = 0;
int revnum;                                 //revnum - reversed number
while (n!=0)
{
    revnum = n%10; 
    reverse = reverse*10 + revnum; 
    n/=10;  
}
if (v == reverse)
{
    Console.WriteLine($"Введенное число: {v}. Перевернутое число: {reverse}. Введенное число является палиндромом.");
}
else if (v != reverse)
{
    Console.WriteLine($"Введенное число: {v}. Перевернутое число: {reverse}. Введенное число не является палиндромом.");
}