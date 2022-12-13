Console.Clear();

void SumMeanOfColumns(int[,] arrayToSum)
{
    Console.Write("Среднее арифметическое столбцов:");
    Console.WriteLine();
    for (int i = 0; i < arrayToSum.GetLength(1); i++)
    {
        int sumColumn = 0;
        for (int j = 0; j < arrayToSum.GetLength(0); j++)
        {
            sumColumn = sumColumn + arrayToSum[j, i];
        }
        double sumMean = Math.Round((double)sumColumn / arrayToSum.GetLength(0), 1);
        Console.WriteLine($"{i}-й - {sumMean}");
    }
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

int mRow = EnterData("Введите размер двумерного массива, кол-во строк: ");
int nColumn = EnterData("... и столбцов: ");
Console.WriteLine();

int leftRange = 1;
int rightRange = 10;
int[,] matrix = CreateArray(mRow, nColumn, leftRange, rightRange);

PrintArray(matrix);
Console.WriteLine();

SumMeanOfColumns(matrix);
