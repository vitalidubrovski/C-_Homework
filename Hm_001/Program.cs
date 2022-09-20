// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Задача 2");
int a = -20;
int b = -3;
if(a>b)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine();
Console.WriteLine("Задача 4");
int c = 2;
int d = 3;
int e = 7;
if((c > d) && (c > e) )
{
    Console.WriteLine($"max = {c}");
}
else if ((d > e) && (d > c))
{
    Console.WriteLine($"max = {d}");
}
else
{
    Console.WriteLine($"max = {e}");
}


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine();
Console.WriteLine("Задача 6");
int num = 7;
if (num % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine();
Console.WriteLine("Задача 8");

int N = 10;
int i = 2;
Console.Write($"{N} ->");
while(i<=N)
{
    
    Console.Write(i + "|" );
    i+=2;
}