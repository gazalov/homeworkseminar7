/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Clear();

void PrintArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($" {arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArray(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (rightRange - leftRange) + leftRange, 1);
        }
    }
    return array;
}

int EnterDimensions(string message)
{
    Console.WriteLine(message);
    int dimension = int.Parse(Console.ReadLine());
    return dimension;
}

int m = EnterDimensions("Введите размер двумерного массива, m: ");
int n = EnterDimensions("... и n: ");

int leftRange = -10;
int rightRange = 10;
double[,] matrix = CreateArray(m, n, leftRange, rightRange);

PrintArray(matrix);
