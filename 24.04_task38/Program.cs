// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(min + ((rnd.NextDouble()) * (max - min)), 1); ;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

Console.WriteLine("укажите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int minArray = 0;
int maxArray = 99;
double[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
double maxElementArray = FindMax(array);
double minElementArray = FindMin(array);
Console.WriteLine(Math.Round ((maxElementArray + minElementArray), 1));