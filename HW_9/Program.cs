// Task 1 / Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

// All you need to know is how to copy and paste the code :P
/*
void TheFinalCountdown(int finalNumber)
{
    Console.Write($"{finalNumber} ");

    if (finalNumber > 1)
        TheFinalCountdown(finalNumber - 1);
}

Console.Write("Enter the last number of range: ");
int superDuperNumber = Convert.ToInt32(Console.ReadLine());
TheFinalCountdown(superDuperNumber);

*/
// It's the final countdown!!!

// Task 2 / Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

// All you need to know is how to copy and paste the code :P (2)
/*
int GetSumOfRange(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
        return GetSumOfRange(firstNumber, secondNumber + 1) + secondNumber;

    else if (secondNumber > firstNumber)
        return GetSumOfRange(firstNumber + 1, secondNumber) + firstNumber;

    else
        return firstNumber;
}

Console.Write("Enter the first number of range: ");
int firstSuperDuperNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the last number of range: ");
int secondSuperDuperNumber = Convert.ToInt32(Console.ReadLine());

int sumOfRange = GetSumOfRange(firstSuperDuperNumber, secondSuperDuperNumber);

Console.WriteLine($"The sum of range [{firstSuperDuperNumber}, {secondSuperDuperNumber}]: {sumOfRange}");
*/

// Task 3 / Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int AckermannFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
        return secondNumber + 1;
    else if (firstNumber > 0 && secondNumber == 0)
        return AckermannFunction(firstNumber - 1, 1);
    else
        return AckermannFunction(firstNumber - 1, AckermannFunction(firstNumber, secondNumber - 1));
}


Console.Write("Enter the first number (m): ");
int firstSuperNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number (n): ");
int secondSuperNumber = Convert.ToInt32(Console.ReadLine());

int ackermannResult = AckermannFunction(firstSuperNumber, secondSuperNumber);

Console.WriteLine($"A({firstSuperNumber},{secondSuperNumber}) = {ackermannResult}");