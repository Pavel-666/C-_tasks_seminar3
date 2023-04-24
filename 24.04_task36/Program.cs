// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

void PrintArray (int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
else Console.Write($"{arr[i]}");
}
}

int SumUnevenElements (int[] arr)
{
int sum = 0;
for (int i = 1; i < arr.Length; i = i + 2)
{
    sum += arr[i];
}
return sum;
}

Console.WriteLine("укажите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int minArray = 0;
int maxArray = 99;
int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
int sumUnevenElements = SumUnevenElements(array);
Console.WriteLine($"сумма элементов с нечетной позицией = {sumUnevenElements}");