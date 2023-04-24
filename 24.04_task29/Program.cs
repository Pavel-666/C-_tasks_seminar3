// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
ArrayIn(array);
ArrayPrint(array);

void ArrayIn(int[] array)
{
   int length = array.Length;
   for (int i = 0; i <length; i++)
   {
      array[i] = new Random().Next(0, 100);
   }
}

void ArrayPrint(int[] array)
{
   int length = array.Length;
   Console.Write ("[");
   for (int i = 0; i < length -1; i++)
   {
      
      Console.Write($"{array[i]}, ");
   }
   Console.Write(array[length -1]);
   Console.Write("]");
}