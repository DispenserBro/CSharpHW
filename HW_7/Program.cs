int[,] ReturnRandom2DArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2DArray(int[,] array, string msg="Generated array:\n")
{
    Console.WriteLine(msg);

    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");

        Console.WriteLine();
        }

    Console.WriteLine();
}

// Task 1 / Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
double[,] ReturnRandomDouble2DArray(int rows, int cols, int multiplier = 2, int cut = 3)
{
    double[,] array = new double[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = Math.Round(new Random().NextDouble() * Math.Pow(10, multiplier), cut);

    return array;
}

void ShowDouble2DArray(double[,] array, string msg="Generated array:\n")
{
    Console.WriteLine(msg);

    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");

        Console.WriteLine();
        }

    Console.WriteLine();
}

Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter power of 10 (n in 10^n): ");
int beforePoint = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count digits after decimal point: ");
int afterPoint = Convert.ToInt32(Console.ReadLine());

double[,] randDoubleArr = ReturnRandomDouble2DArray(numX, numY, beforePoint, afterPoint);
ShowDouble2DArray(randDoubleArr);
*/
// Task 2 / Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
/*
string ReturnElOfArray(int i, int j, int[,] array)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
        return array[i,j].ToString();
    return $"there's no such element at ({i}, {j}) position";
}

Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
Show2DArray(rand2DArr);

Console.Write("Enter an x coordinate of element: ");
int xIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter an x coordinate of element: ");
int yIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ReturnElOfArray(xIndex, yIndex, rand2DArr));
*/

// Task 3 / Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

double[] GetColumnAverage(int[,] array)
{
    double[] averages = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
        {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];

        double avg = sum / array.GetLength(0);
        averages[j] = avg;
        }

    return averages;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }

    Console.WriteLine();
}

Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] rand2DArr = ReturnRandom2DArray(numX, numY, min, max);
Show2DArray(rand2DArr);
double[] rand2DArrAvgs = GetColumnAverage(rand2DArr);
ShowDoubleArray(rand2DArrAvgs);