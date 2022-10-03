// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34");
int[] array = new int[5];
Random rand = new Random();
FillArray(array);
PrintArray(array);
Console.WriteLine("Количество четных: " + EvenNumbers(array));
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] collect)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < collect.Length; i++)
    {
        Console.Write($"{collect[i]}|");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}


//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine();
Console.WriteLine("Задача 36");
Console.WriteLine("Cумма элементов на нечетных позициях: " + SumOfOdd(array));

int SumOfOdd(int[] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.Length; i += 2)
    {
        sum += collection[i];
    }
    return sum;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.WriteLine();
Console.WriteLine("Задача 38");
double [] arr = new double [5];
FillArray1(arr);
PrintArray1(arr);
Console.WriteLine("Разница между наибольшим и наименшим: " + Math.Round(Difference(arr),2));
void FillArray1(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rand.NextDouble() * 20 - 10;
    }
}

void PrintArray1(double[] collect)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < collect.Length; i++)
    {
        Console.Write($"{Math.Round(collect[i],2)}|");
    }
    Console.WriteLine();
}

double Difference (double [] array)
{
    double max = 0;
    double min = 0;
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        max = array.Max<double>();
        min = array.Min<double>();
    }
    diff = max - min;
    return diff;
}