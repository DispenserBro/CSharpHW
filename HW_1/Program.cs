//Task 1 / Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
/*
Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max)
    max = secondNumber;

Console.WriteLine($"max = {max}");
*/

//Task 2 / Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max)
    max = secondNumber;

if (thirdNumber > max)
    max = thirdNumber;

Console.WriteLine($"max = {max}");
*/

//Task 3 / Задача 6
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.Write("Enter a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isEven = number % 2 == 0;

if (isEven)
    Console.WriteLine($"Number {number} is even");
else
    Console.WriteLine($"Number {number} is odd");
*/

//Task 4 / Задача 8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= number)
{
    if (counter % 2 == 0)
    {
        if (counter + 2 > number)
            Console.Write($"{counter}");
        else
            Console.Write($"{counter}, ");
    }
    
    counter++;
}