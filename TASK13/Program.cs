// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int p = n;
if (p>=100 && p<1000)
{
    p = p%10;
    Console.WriteLine(p);
}
if (p>=1000 && p<10000) //Далее начинается copypast с увеличением числа знаков. Как сделать данный код легче до меня пока не дошло.
{
    p = p/10;
    p = p%10;
    Console.WriteLine(p);  
}
if (p>=10000 && p<100000)
{
    p = p/100;
    p = p%10;
    Console.WriteLine(p);
}
if (p>=100000 && p<1000000)
{
    p = p/1000;
    p = p%10;
    Console.WriteLine(p);
}
if (p>=1000000 && p<10000000)
{
    p = p/10000;
    p = p%10;
    Console.WriteLine(p);
}
if (p>=10000000 && p<100000000)
{
    p = p/100000;
    p = p%10;
    Console.WriteLine(p);
}
if (p>=100000000 && p<1000000000)
{
    p = p/1000000;
    p = p%10;
    Console.WriteLine(p);
}
if (p>=1000000000 && p<10000000000)
{
    p = p/10000000;
    p = p%10;
    Console.WriteLine(p);
}
else if (n<100)
{
    Console.WriteLine("Третьей цифры нет.");
}