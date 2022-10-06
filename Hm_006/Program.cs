// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Задача 41");
Console.WriteLine("Введите количество чисел");
int elementCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementCount];
for (int i = 0; i < elementCount; i++)
{
    Console.WriteLine("Введите эти числа через <Enter>");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] collection)
{
    Console.WriteLine("Вывод чисел:");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]}|");
    }
    Console.WriteLine();
}
void Compare(int[] coll)
{
    int count = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
PrintArray(array);
Compare(array);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine();
Console.WriteLine("Задача 43");
Console.WriteLine("Введите координату А для отрезка AB");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введитн координату B для отрезка AB");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату С для отрезка CD");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату D для отрезка CD");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
x = (b2 - b1) / (k1 - k2); // TODO: y = k1*x+b1
double y = 0;
y = k1 * ((b2 - b1) / (k1 - k2)) + b1; // TODO: y = k2*x+b2
if ((b1 / b2)
    == (k1 / k2))
{
    Console.WriteLine("Прямые не пересекаются");
}
else
Console.WriteLine(Math.Round(x,2) + "|" + Math.Round(y,2));