// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],5} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] MatrixInArray(int[,] mtr)
// {
//     int[] arr = new int[mtr.Length];
//     int x = 0;
//     for (int i = 0; i < mtr.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtr.GetLength(1); j++)
//         {
//             arr[x] = mtr[i, j];
//             x++;
//         }
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
// }

// void DictionaryCounter(int[] arr)
// {
//     int number = arr[0];
//     int count = 1;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] == number) count++;
//         else
//         {
//             Console.WriteLine($" число {number} встречается {count} раз");
//             count = 1;
//             number = arr[i];
//         }
//     }
//     Console.WriteLine($" число {number} встречается {count} раз");
// }

// int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
// PrintMatrix(matrix);
// Console.WriteLine();
// int[] array = MatrixInArray(matrix);
// PrintArray(array);
// Console.WriteLine();
// Array.Sort(array);
// PrintArray(array);
// Console.WriteLine();
// DictionaryCounter(array);


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
int[] FindMinPosition(int[,] matrix)
{
   int min = matrix[0, 0];
   int position1 = 0;
   int position2 = 0;
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j <matrix.GetLength(1); j++)
      {
         if (matrix[i,j]<min) 
         {
            min = matrix[i, j];
            position1 = i;
            position2 = j;
         }
      }
   }
   return new int[]{position1,position2,min};
}
int[,] CreateNewMatrix(int[,] matrix,int row, int column)
{
   int size1 = matrix.GetLength(0)-1;
   int size2 = matrix.GetLength(1)-1;
   int[,] newMatrix = new int[size1, size2];
   int m = 0;
   int n = 0;
   for (int i = 0; i < newMatrix.GetLength(0); i++)
   {
      if (m==row) m+=1;
      for (int j = 0; j < newMatrix.GetLength(1); j++)
      {
         if (n==column) n+=1;
         newMatrix[i, j] = matrix[m, n];
         n++;
      }
      n = 0; //обнуление после каждой строки
      m++;
   }
   return newMatrix;

}

int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] pos = FindMinPosition(matrix);
int min = pos[2];
int[,] newMatrix = CreateNewMatrix(matrix, pos[0],pos[1]);
Console.WriteLine(min);
Console.WriteLine();
PrintMatrix(newMatrix);