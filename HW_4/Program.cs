﻿// Task 1 / Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
/*
int PowerNumber(int number, int power)
{
    int result = number;

    for (int pow = 1; pow < power; pow++)
        result *= number;

    return result;
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a natural power: ");
int power = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num}^{power} equals {PowerNumber(num, power)}");
*/

// Task 2 / Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
/*
int SumDigits(int number)
{
    int result = 0;
    int numberCopy = number;

    while (numberCopy != 0)
    {
        result += numberCopy % 10;
        numberCopy /= 10;
    }

    return result;
}

Console.Write("Enter a number: ");
int mySuperCoolNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in {mySuperCoolNumber} equals {SumDigits(mySuperCoolNumber)}");
*/

// Task 3 / Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// Fixed elements count
/*
int[] ReturnEnteredArray()
{
    int size = 8;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter the {i + 1} element of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void ShowArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");

    Console.WriteLine("\nThat's all folks!");
}

int[] mySuperDuperArray = ReturnEnteredArray();
ShowArray(mySuperDuperArray);
*/

// Custom elements count
int[] ReturnEnteredArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter the {i + 1} element of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    // foreach
    foreach (int el in array)
        Console.Write($"{el} ");

    // for
    // for (int i = 0; i < array.Length; i++)
    // {
    //     int el = array[i];
    //     Console.Write($"{el} ");
    // }

    Console.WriteLine("\nThat's all folks!");
}

Console.Write("Enter a number of elements: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] mySuperDuperArray = ReturnEnteredArray(arraySize);
ShowArray(mySuperDuperArray);