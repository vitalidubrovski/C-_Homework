// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Задача 19");
Console.WriteLine("Введите 5-ти значное число: ");
string polinomial = Console.ReadLine()!;
if (polinomial.Length == 5)
{
    if (polinomial[0] == polinomial[4] && polinomial[1] == polinomial[3])
    {
        Console.WriteLine("число является полиномом");
    }
    else
    {
        Console.WriteLine("число не является полиноном");
    }
}
else
{
    Console.WriteLine("Не верно, попробуй еще раз");
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine();
Console.WriteLine("Задача 21");
Random rand = new Random();
int a_x = rand.Next(1, 10);
int a_y = rand.Next(1, 10);
int a_z = rand.Next(1, 10);
int b_x = rand.Next(1, 10);
int b_y = rand.Next(1, 10);
int b_z = rand.Next(1, 10);

Console.WriteLine($"Точка А = {a_x}:{a_y}:{a_z}");
Console.WriteLine($"Точка B = {b_x}:{b_y}:{b_z}");

double distance_x = Math.Pow((b_x - a_x), 2);
double distance_y = Math.Pow((b_y - a_y), 2);
double distance_z = Math.Pow((b_z - a_z), 2);
double result = Math.Sqrt(distance_x + distance_y + distance_z);
Console.WriteLine("Длина отрезка: " + Math.Round(result, 2));

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine();
Console.WriteLine("Задача 23");
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a + " ==>" + " ");
for (int i = 1; i <= a; i++)
{
    Console.Write(Math.Pow(i, 3) + "| ");
}