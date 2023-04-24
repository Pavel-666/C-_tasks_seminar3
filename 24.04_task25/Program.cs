// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Еxponentiation (int numA, int numB)
{
   int count = 0;
   int deg = 1;
   while (count < numB)
   {
        deg = deg * numA;
        count++;
   }
   return deg;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int degree = Convert.ToInt32(Console.ReadLine());
int exponentiation = Еxponentiation(number, degree);
Console.WriteLine(exponentiation);