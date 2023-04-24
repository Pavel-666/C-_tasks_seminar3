// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int SearchHonestElements (int[] arr)
{
int temp = 0;
for (int i = 0; i < arr.Length; i++)
{
if(arr[i] % 2 == 0) temp += 1;
}
return temp;
}

Console.WriteLine("укажите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int minArray = 100;
int maxArray = 999;
int[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
int honest = SearchHonestElements(array);
Console.WriteLine($"количество четных элементов = {honest}");