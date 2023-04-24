// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Summing(int num)
{
   int sumA = 0;
   while (num != 0)
   {
        int add = num % 10;
        sumA = sumA + add;
        num = num / 10;
   }
   return sumA;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summing = Summing(number);
Console.WriteLine(summing);