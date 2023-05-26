// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

bool TestСompositionMatrixs(int[,] mtr1, int[,] mtr2)
{
    if (mtr1.GetLength(1) == mtr2.GetLength(0)) return true;
    else return false;
}

int[,] СompositionTwoMatrix(int[,] mtr1, int[,] mtr2)
{
    int[,] mtrComp = new int[mtr1.GetLength(0), mtr2.GetLength(1)];
    for (int i = 0; i < mtr1.GetLength(0); i++)
    {
        for (int j = 0; j < mtr2.GetLength(1); j++)
        {
            for (int k = 0; k < mtr2.GetLength(0); k++)
            {
                mtrComp[i, j] += mtr1[i, k] * mtr2[k, j];
            }
        }
    }
    return mtrComp;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, -10, 10);
int[,] matrix2 = CreateMatrixRndInt(2, 2, -10, 10);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
bool testСompositionMatrixs = TestСompositionMatrixs(matrix1, matrix2);
if (testСompositionMatrixs == true)
{
    int[,] compositionTwoMatrix = СompositionTwoMatrix(matrix1, matrix2);
    PrintMatrix(compositionTwoMatrix);
    Console.WriteLine();
}  
else Console.WriteLine("матрицы нельзя перемножить");