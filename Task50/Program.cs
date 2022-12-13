/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();

void ToFindNumber(int[,] arrayToCheck, int refNumber)
{
    bool check = false;
    int checkPositionI = 0;
    int checkPositionJ = 0;
    for (int i = 0; i < arrayToCheck.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToCheck.GetLength(1); j++)
        {
            if (arrayToCheck[i, j] == refNumber)
            {
                check = true;
                checkPositionI = i;
                checkPositionJ = j;
                break;
            }
        }
    }
    if (check) Console.WriteLine($"Есть такое число {refNumber}, позиция: {checkPositionI}, {checkPositionJ}.");
    else Console.WriteLine($"Числа {refNumber} нет.");
}

void PrintArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterData(string message)
{
    Console.Write(message);
    int inputData = int.Parse(Console.ReadLine());
    return inputData;
}

int mRow = EnterData("Введите размер двумерного массива, m: ");
int nColumn = EnterData("... и n: ");
int numberToFind = EnterData("Введите искомое число от 10 до 99: ");
Console.WriteLine();

int leftRange = 10;
int rightRange = 100;
int[,] matrix = CreateArray(mRow, nColumn, leftRange, rightRange);

PrintArray(matrix);
Console.WriteLine();

ToFindNumber(matrix, numberToFind);
