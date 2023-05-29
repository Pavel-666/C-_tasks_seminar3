//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите чилое натуральное число M");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чилое натуральное число N");
int number1 = Convert.ToInt32(Console.ReadLine());

SumPrint(number, number1);


int NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        int temp = num2;
        num2++;
        temp = num2 + NaturalNumbers(num1, num2);
        return temp;
    }
    else if (num1 < num2)
    {
        int temp = num1;
        num1++;
        temp = num1 + NaturalNumbers(num1, num2);
        return temp;
    }
    else return 0;
}


void SumPrint(int num1, int num2)
{
    if (num1 < num2)
    Console.Write(NaturalNumbers(num1 - 1, num2));
    else Console.Write(NaturalNumbers(num1, num2 - 1 ));
}