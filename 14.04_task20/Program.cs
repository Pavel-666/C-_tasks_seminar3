// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance(int x1, int y1, int x2, int y2 )
{
   double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
   return dist;
}



Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("x =");
int xcor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int ycor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("x =");
int xcor2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int ycor2 = Convert.ToInt32(Console.ReadLine());


double distance = Distance(xcor1, ycor1, xcor2, ycor2);
double distanceRound = Math.Round(distanse, 2);
Console.WriteLine($"расстояние между точками = {distanceRound}");