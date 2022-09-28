// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Задача 25");
Random rand = new Random();
int a = rand.Next(1, 10);
int b = rand.Next(1, 10);
Console.WriteLine($"{a},{b} ==> {Get_Pow(a, b)}");

int Get_Pow(int first, int second)
{
    int result = 1;
    for (int i = 0; i < second; i++)
    {
        result *= first;
    }
    return result;
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine();
Console.WriteLine("Задача 27");
int number = rand.Next(10, 100000);
Console.WriteLine($"{number} ==> {DigitsOfNumber(number)}");


int DigitsOfNumber(int digits)
{
    int sum = 0;
    while (digits > 0)
    {
        sum += digits % 10;
        digits /= 10;
    }
    return sum;
}


// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine();
Console.WriteLine("Задача 29");

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rand.Next(1,27);
    }
}

void PrintArray(int [] collect)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < collect.Length; i++)
    {
        Console.Write($"{collect[i]}|");
    }
    Console.WriteLine();
}