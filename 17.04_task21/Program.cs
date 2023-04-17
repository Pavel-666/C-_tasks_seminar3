// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance(int x1, int y1, int z1, int x2, int y2, int z2 )
{
   double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
   return dist;
}



Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("x =");
int xcord1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int ycord1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z =");
int zcord1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("x =");
int xcord2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int ycord2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z =");
int zcord2 = Convert.ToInt32(Console.ReadLine());


double distance = Distance(xcord1, ycord1, zcord1, xcord2, ycord2, zcord2);
double distanceRound = Math.Round(distance, 2);
Console.WriteLine($"расстояние между точками = {distanceRound}");