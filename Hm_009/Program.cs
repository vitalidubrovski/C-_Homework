// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Задача 64");
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Rec(n)}");
string Rec(int max)
{
    if (max == 1) { return max.ToString(); }
    return (max + " " + Rec(max - 1));
}


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine();
Console.WriteLine("Задача 66");
Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Recurs(M, N)}");
int Recurs(int min, int max)
{
    if (min == max) { return max; }
    return min + Recurs(min + 1, max);
}

//Задача 68: Напишите программу вычисления функции Аккермана
//   с помощью рекурсии. Даны два неотрицательных числа m и n.
// Шляпа какая-то. Это максимум, что эта рекурсия может посчитать  =>> 3\5
Console.WriteLine();
Console.WriteLine("Задача 68");
int a = 3;
int b = 5;
int Ack(int n, int m)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return Ack(n - 1, 1);
    return Ack(n - 1, Ack(n, m - 1));
}
Console.WriteLine(Ack(a, b));