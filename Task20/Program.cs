// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21



Console.WriteLine("Введите координаты точки X1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки X2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance (int x1Val, int x2Val, int y1Val, int y2Val)
{
    return Math.Sqrt((x1Val-x2Val) * (x1Val-x2Val) + (y1Val-y2Val) * (y1Val-y2Val));
}

double res = Distance(x1,x2,y1,y2);
Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) -> {res}");
