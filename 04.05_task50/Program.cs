// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


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

double SearchMatrix(int[,] matrix, int row, int column)
{
    if (row -1 < matrix.GetLength(0) && column -1 < matrix.GetLength(1) )
        { 
            return matrix[row - 1, column -1 ];
        }
    else return 0.1;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine(" |");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("Введите номер строки");
int pozitionX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int pozitionY = Convert.ToInt32(Console.ReadLine());
double number = SearchMatrix(array2d, pozitionX, pozitionY);
if (number == 0.1) 
{
    Console.WriteLine("такого элемента нет"); 
}
else Console.WriteLine(number);
