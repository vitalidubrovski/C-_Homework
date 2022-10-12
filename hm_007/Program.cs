// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
Console.WriteLine("Задача 47");
int rows = 4;
int columns = 4;
int[,] matrix = new int[rows, columns];
Random random = new Random();
CreateAndFillArray(matrix);
void CreateAndFillArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = random.Next(0, 10);
            Console.Write($"{coll[i, j]}| ");
        }
        Console.WriteLine();
    }
}


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine();
Console.WriteLine("Задача 50");

Console.WriteLine("Введите позицию по строкам I: ");
int rowsI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию по столбцам J: ");
int columnsJ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
GetPosition(matrix, rowsI, columnsJ);
void GetPosition(int[,] arr, int m, int n)
{

    if (m <= arr.GetLength(0) - 1 && n <= arr.GetLength(1) - 1)
    {
        Console.WriteLine(arr[m, n]); return;
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
        return;
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine();
Console.WriteLine("Задача 52");
ArithmeticMean(columns, matrix);
 double ArithmeticMean(int n, int[,] collection)
{
    double sum = 0;
    double result = 0;
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            sum += collection[i, j];
        }
    result = sum / n;
    Console.Write($"{Math.Round(result,2)} ");
    sum = 0;
    }
    return result;
    
}