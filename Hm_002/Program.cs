// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Задача 10");
int num = 918;
int result = num / 10 % 10;
Console.WriteLine($"{num} -> {result}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine();
Console.WriteLine("Задача 13");
int num1 = 32679;
int result1;
if (num1 < 100)
{
    Console.WriteLine($"{num1} -> Третьей цифры нет");
}
else if ((num1 >= 1000) && (num1 < 10000))
{
    result1 = (num1 % 100) /10;
    Console.WriteLine($"{num1} -> {result1}");
}
else if ((num1 >= 10000)&& (num1 <100000))
{
    result1 = (num1 %1000) /100;
     Console.WriteLine($"{num1} -> {result1}");
}
else
{
    result1 = num1 % 10;
    Console.WriteLine($"{num1} -> {result1}");
}


//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine();
Console.WriteLine("Задача 15");
Console.WriteLine("Введите день недели(цифру)");
int x = Convert.ToInt32(Console.ReadLine());
WeekEnds(x);

void WeekEnds(int daynumber)
{
    if(daynumber == 1)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Понедельник ");
    }
    else if(daynumber == 2)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Вторник");
    }
    else if(daynumber == 3)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Среда");
    }
    else if(daynumber == 4)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Четверг");
    }
    else if(daynumber == 5)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Пятница");
    }
    else if(daynumber == 6)
    {
        Console.WriteLine(daynumber + " -> " +  "Да"  +  " Суббота.Выходной");
    }
    else if(daynumber == 7)
    {
        Console.WriteLine(daynumber + " -> " +  "Да"  +  " Воскресенье.Выходной");
    }
    else
    {
        Console.WriteLine("Не верное значение, попробуй еще раз");
    }
}

