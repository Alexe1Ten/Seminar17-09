// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -
// > (-0,5; -0,5)

int InputNum(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double resX = 0;
    double resY = 0;
    resX = (b2 - b1) / (k1 - k2);
    resY = k1 * resX + b1;
    double[] result = new double[2] { resX, resY };
    return result;
}

double b1 = InputNum("Введите b1: ");
double k1 = InputNum("Введите к1: ");
double b2 = InputNum("Введите b2: ");
double k2 = InputNum("Введите к2: ");

double[] intersectionPoint = IntersectionPoint(b1,k1,b2,k2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({intersectionPoint[0]}, {intersectionPoint[1]})");

