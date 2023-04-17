// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int numberforth = Convert.ToInt32(Console.ReadLine());


string quarter = Quarter(numberforth);
Console.WriteLine(quarter);

string Quarter(int x)
{
    if(x == 1) return "x > 0 and y > 0";
    if(x == 2) return "x < 0 and y > 0";
    if(x == 3) return "x < 0 and y < 0";
    if(x == 4) return "x > 0 and y < 0";
    return "error";
}