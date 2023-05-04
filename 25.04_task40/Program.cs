// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон


Console.WriteLine("Please enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool triangleSearch = TriangleSearch (number1, number2, number3);
Console.WriteLine(triangleSearch ? "такой треугольник существует" : "такой треугольник не существует");

bool TriangleSearch (int num1, int num2, int num3)
{
    return num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2;
}

