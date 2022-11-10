// int[] GetRandomIntArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Generated array:");

//     string indexes = "indexes\t";
//     string values = "values\t";

//     for (int i = 0; i < array.Length; i++)
//     {
//         indexes += $"{i}\t";
//         values += $"{array[i]}\t";
//     }

//     Console.WriteLine(indexes);
//     Console.WriteLine(values);
//     Console.WriteLine();
// }

Console.Write("Enter a number of elements: ");
int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a minimal possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a maximal possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Task 1 / Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
/*
int GetEvenNumbersCount(int[] array)
{
    int count = 0;

    foreach (int el in array)
        if (el % 2 == 0)
            count++;

    return count;
}

int[] randArr = GetRandomIntArray(num, 100, 999);
ShowArray(randArr);
int evenNumbers = GetEvenNumbersCount(randArr);
Console.WriteLine($"There are {evenNumbers} even numbers in the array");
*/

// Task 2 / Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
/*
int GetSumElsOnOddPos(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1)
            sum += array[i];

    return sum;
}

int[] randArray = GetRandomIntArray(num, min, max);
ShowArray(randArray);
int sum = GetSumElsOnOddPos(randArray);
Console.WriteLine("Sum of elements on odd positions: " + sum);
*/

// Task 3 / Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

Console.Write("Enter power of 10 (n in 10^n): ");
int beforePoint = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count digits after decimal point: ");
int afterPoint = Convert.ToInt32(Console.ReadLine());

double[] GetRandomDoubleArray(int size, int multiplier = 2, int cut = 3)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble() * Math.Pow(10, multiplier), cut);
    return array;
}

void ShowDoubleArray(double[] array)
{
    Console.WriteLine("Generated array:");

    string values = "values\t";

    for (int i = 0; i < array.Length; i++)
    {
        values += $"{array[i]}\t";
    }

    Console.WriteLine(values);
    Console.WriteLine();
}

double GetDiffBetweenMaxAndMin(double[] array, int cut)
{
    double max = array[0];
    double min = array[0];

    foreach (double el in array)
    {
        if (el > max) max = el;
        if (el < min) min = el;
    }

    return Math.Round(max - min, cut);
}

double[] randDoubleArr = GetRandomDoubleArray(num, beforePoint, afterPoint);
ShowDoubleArray(randDoubleArr);
double diff = GetDiffBetweenMaxAndMin(randDoubleArr, afterPoint);
Console.WriteLine($"Difference between max and min value of the array: {diff}");