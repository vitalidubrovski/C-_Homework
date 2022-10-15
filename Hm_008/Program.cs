// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Задача 54");
Random random = new Random();
int rows = 4;
int columns = 4;
int[,] matrix = new int[rows, columns];
FillMatrix(matrix);
PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine("Сортировка: ");
PrintMatrix(matrix);
int[,] FillMatrix(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = random.Next(1, 10);
        }
    }
    return collection;
}

void PrintMatrix(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]}  \t");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
}



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine();
Console.WriteLine("Задача 56");
int m = 4;
int n = 6;
int[,] matrixx = new int[m, n];
FillMatrix(matrixx);
PrintMatrix(matrixx);
SummDiffMatrix(matrixx);
void SummDiffMatrix(int[,] collect)
{
    int[] arraySumm = new int[m]; // Массив для хранения суммы
    for (int i = 0; i < m; i++)
    {
        int summ = 0;
        for (int j = 0; j < n; j++)
        {
            summ += collect[i, j];
        }
        arraySumm[i] = summ;
        Console.WriteLine(summ);
    }

    int min = 0;
    for (int k = 1; k < arraySumm.Length; k++)
    {
        if (arraySumm[k] == arraySumm[min])
        {
            Console.WriteLine("Суммы равны");
        }
        if (arraySumm[k] < arraySumm[min])
        {
            min = k;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой " + (min + 1));


}

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine();
Console.WriteLine("Задача 58");
int[,] matrixA = new int[rows, columns];
int[,] matrixB = new int[rows, columns];
FillMatrix(matrixA);
FillMatrix(matrixB);
Console.WriteLine("Вывод матрицы А: ");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Вывод матрицы В: ");
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Вывод валидной матрицы: ");
int[,] result = MatrixProduct(matrixA, matrixB);
PrintMatrix(result);
int[,] MatrixProduct(int[,] matrix, int[,] matrix1)
{
    int[,] resultMatrix = new int[rows, columns];
    if (rows != columns)
    {
        Console.WriteLine("Нельзя вычислить произведение!");
    }
    for (int i = 0; i < rows; i++) // каждая строка A
    {
        for (int j = 0; j < columns; j++) // каждый столбец B
        {
            for (int k = 0; k < rows; k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }

    }
    return resultMatrix;
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine();
Console.WriteLine("Задача 60");
int[,,] resultt = GetCube(3, 3, 3);
PrintCube(resultt);
int[,,] GetCube(int x, int y, int z)
{
    int number = 10;
    int[,,] matrix3D = new int[x, y, z];
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = number;
                number++;
            }
        }
    }
    return matrix3D;
}
void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write(" Элемент " + $"{cube[i, j, k]} с индексом ({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Мне стыдно за эту дичь, не понимаю, как решить, сделал совсем по цигански просто методом подбора конечного значения
Console.WriteLine();
Console.WriteLine("Задача 62");
int T = 4;
int[,] mass = new int[T,T]; //Мягко говоря, я в шоке Т_Т
SpiralMatrix(mass);
PrintMatrix(mass);
int [,] SpiralMatrix(int[,] massive)
{
    int spiral = 1;
    int i, j;
    for (j = 0, i = 0; j < T; j++)
    {
        massive[i, j] = spiral;
        spiral++;
    }
    spiral--;

    for (i = 0, j = T - 1; i < T; i++)
    {
        massive[i, j] = spiral;
        spiral++;
    }
    spiral--;

    for (j = T - 1, i = T - 1; j >= 0; j--)
    {
        massive[i, j] = spiral;
        spiral++;
    }
    spiral--;
    for (i = T - 1, j = 0; i >= 1; i--)
    {
        massive[i, j] = spiral;
        spiral++;
    }

    for (i = 1, j = 1; i < T - 1; i++)
    {
        massive[j, i] = spiral;
        spiral++;
    }
    for (i = T - 2, j = T - 2; i >= 1; i--)
    {
        massive[j, i] = spiral;
        spiral++;
    }
    return massive;
}