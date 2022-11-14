// Task 1 / Задача 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
/*
int GetNaturalCount(int numbers)
{
    int naturals = 0, counter = 0;
    while (counter < numbers)
    {
        Console.Write($"Enter the {counter + 1} number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) naturals++;
        counter++;
    }
    return naturals;
}

Console.Write("Enter count of numbers: ");
int numCount = Convert.ToInt32(Console.ReadLine());
int natural = GetNaturalCount(numCount);
Console.WriteLine($"There's {natural} natural numbers");
*/

// Task 2 / Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

string GetPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
            return $"y = {k1} * x + {b1} and y = {k2} * x + {b2}\nAre the same lines";

        return $"y = {k1} * x + {b1} and y = {k2} * x + {b2}\nAre the parallel lines";
    }
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return $"The point of intersection of\ny = {k1} * x + {b1} and y = {k2} * x + {b2}\nIs ({x}, {y})";
}

Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(GetPoint(b1, k1, b2, k2));