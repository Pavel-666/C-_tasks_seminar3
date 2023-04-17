// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool FiveDigit(int num)
{
   return num > 9999 && num < 100000;
}

bool Polyander (int num)
{
    return num % 10 == num / 10000 && num % 10000 / 1000 == num % 100 / 10;
}

Console.WriteLine("Please enter a five-digit number");
int number = Convert.ToInt32(Console.ReadLine());
bool fiveDigit = FiveDigit(number);
bool polyander = Polyander(number);
if (fiveDigit == true)
    Console.WriteLine(polyander ? "yes" : "no");
else Console.WriteLine("your number is not five-digit");