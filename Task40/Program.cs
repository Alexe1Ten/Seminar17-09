// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool isTriangle(int a, int b, int c)
{
    if (c > a + b) return true;
    else if (b > a + c) return true;
    else if (a > b + c) return true;
    else return false;
}

int InputNum(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int aSide = InputNum("Введите сторону a: ");
int bSide = InputNum("Введите сторону b: ");
int cSide = InputNum("Введите сторону c: ");

if (isTriangle(aSide, bSide, cSide)) Console.WriteLine("Такой треугольник существует!");
else Console.WriteLine("Такого треугольника не существует!");