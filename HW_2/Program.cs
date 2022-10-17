// Task 1 / Задача 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/*
int ReturnSecondDigit(int number)
{
    // return number / 10 % 10;
    int lastTwoDigits = number / 10;
    int secondDigit = lastTwoDigits % 10;
    return secondDigit;
}

Console.Write("Enter three-digit number: ");
int input = Convert.ToInt32(Console.ReadLine());
int result = ReturnSecondDigit(input);

Console.WriteLine($"Second digit of {input} is {result}");
*/

// Task 2 / Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int ReturnThirdDigit(int number)
{
    // with convert to string
    string numberString = number.ToString();
    int output = numberString.Length > 2 ? Convert.ToInt32($"{numberString[2]}") : -1;
    return output;

    // without convert to string
    // if (number >= 100)
    // {
    //     int digits = 3;
    //     while (number / Convert.ToInt32(Math.Pow(10, digits)) > 0) digits++;
    //     int thirdDigit = number % Convert.ToInt32(Math.Pow(10, digits - 2)) / Convert.ToInt32(Math.Pow(10, digits - 3));
    //     return thirdDigit;
    // }
    // else return -1;
}

Console.Write("Enter a number: ");
int input = Convert.ToInt32(Console.ReadLine());
int result = ReturnThirdDigit(input);
string outString = result > -1 ? $"{result}" : "there's no third digit";
Console.WriteLine($"{input} --> {outString}");
*/

// Task 3 / Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

bool IsWeekend(int weekday)
{
    // with weekday larger than week
    // return weekday % 7 == 0 || weekday % 7 == 6;
    // only with one week
    return weekday > 5 && weekday < 8;
}

Console.Write("Enter a day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool isWeekend = IsWeekend(dayNumber);

Console.WriteLine(isWeekend ? $"Day {dayNumber} is weekend" : $"Day {dayNumber} is not weekend");
