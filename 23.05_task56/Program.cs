// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

void ArrayPrint(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {

        Console.Write($"{array[i]} ");
    }
}

int[] SumElementdInRows(int[,] mtr)
{
    int[] arr = new int[mtr.GetLength(0)];
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < mtr.GetLength(1); j++)
        {
            sumElement = sumElement + mtr[i, j];
        }
        arr[i] = sumElement;
    }
    return arr;
}

int FindIndexMinElement(int[] arr)
{
    int minIndex = 0;
    int minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}

int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = SumElementdInRows(matrix);
ArrayPrint(array);
Console.WriteLine();
int number = FindIndexMinElement(array);
Console.WriteLine($" {number} строка ");
Console.WriteLine();



