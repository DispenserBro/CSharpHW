// int[,] ReturnRandom2DArray(int rows, int cols, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, cols];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

void Show2DArray(int[,] array, string msg="Generated array:")
{
    Console.WriteLine(msg + "\n");

    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");

        Console.WriteLine('\n');
        }

    Console.WriteLine();
}

// Task 1 / Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
/*
void Sort2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k ] = temp;
                    }
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

Sort2DArray(rand2DArr);
Show2DArray(rand2DArr, "Sorted array:");
*/

// Task 2 / Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
/*
int[] GetRowsSums(int[,] array)
{
    int[] sumsArr = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];

        sumsArr[i] = sum;
    }

    return sumsArr;
}

int GetMinSumRow(int[,] array)
{
    int result = 0;

    int[] rowsSums = GetRowsSums(array);

    for (int i = 0; i < rowsSums.Length; i++)
        if (rowsSums[i] < rowsSums[result])
            result = i;

    return result + 1;
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

int minRow = GetMinSumRow(rand2DArr);
Console.WriteLine("Row with minimal sum: " + minRow);
*/

// Task 3 / Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
/*
int[,] MatricesProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    if (matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                for (int k = 0; k < matrix2.GetLength(0); k++)
                    resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
    }
    return resultMatrix;
}

Console.WriteLine("First matrix data:");
Console.Write("Enter a number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second matrix data:");
Console.Write("Enter a number of rows: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a minimal possible value: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a maximal possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = ReturnRandom2DArray(numX, numY, min, max);
Show2DArray(firstMatrix, "First matrix:");

int[,] secondMatrix = ReturnRandom2DArray(numX2, numY2, min2, max2);
Show2DArray(secondMatrix, "Second matrix:");

int[,] resultMatrix = MatricesProduct(firstMatrix, secondMatrix);
Show2DArray(resultMatrix, "Result matrix:");
*/

// Task 4 / Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
/*
int[] GetUniqueArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minValue, maxValue);

        if (i != 0)
        {
            for (int j = 0; j < i; j++)
                while (array[j] == array[i])
                {
                    array[i] = rand.Next(minValue, maxValue + 1);
                    j = 0;
                }
        }
    }

    return array;
}

int[,,] GetUnique3DArray(int xSize=2, int ySize=2, int zSize=2, int minValue=10, int maxValue=99)
{
    int[,,] array = new int[xSize, ySize, zSize];

    int[] baseArray = GetUniqueArray(xSize * ySize * zSize, minValue, maxValue);

    int baseIndex = 0;

    for (int i = 0; i < xSize; i++)
        for (int j = 0; j < ySize; j++)
            for (int k = 0; k < zSize; k++)
            {
                array[i, j, k] = baseArray[baseIndex];
                baseIndex++;
            }

    return array;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string output = string.Empty;

            for (int k = 0; k < array.GetLength(2); k++)
                output += $"{array[i, j, k]}({i},{j},{k}) ";

            Console.WriteLine(output);
        }

        Console.WriteLine();
    }

}

Console.WriteLine("Enter three dimensions of the array (x * y * z <= 90)");
Console.Write("Enter x dimension of the array: ");
int arrX = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y dimension of the array: ");
int arrY = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z dimension of the array: ");
int arrZ = Convert.ToInt32(Console.ReadLine());

int[,,] rand3DArr = GetUnique3DArray(arrX, arrY, arrZ);
Show3DArray(rand3DArr);
*/

// Task 5 / Задача 62
// Напишите программу, которая заполнит спирально массив 4 на 4
// * Сделать для заполнения любого массива

void SnailFillArray(int[,] array)
{
    int iStart = 0, iEnd = 0, jStart = 0, jEnd = 0;

    int i = 0;
    int j = 0;

    for (int k = 0; k < array.Length; k++)
    {
        array[i, j] = k + 1;
        if (i == iStart && j < array.GetLength(1) - jEnd - 1)
            j++;
        else if (j == array.GetLength(1) - jEnd - 1 && i < array.GetLength(0) - iEnd - 1)
            i++;
        else if (i == array.GetLength(0) - iEnd - 1 && j > jStart)
            j--;
        else
            i--;

        if ((i == iStart + 1) && (j == jStart) && (jStart != array.GetLength(1) - jEnd - 1)){
            iStart++;
            iEnd++;
            jStart++;
            jEnd++;
        }
    }
}

Console.Write("Enter a number of rows: ");
int snailRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns: ");
int snailCols = Convert.ToInt32(Console.ReadLine());
int[,] snailArr = new int[snailRows, snailCols];
Show2DArray(snailArr);
SnailFillArray(snailArr);
Show2DArray(snailArr, "Filled array:");
