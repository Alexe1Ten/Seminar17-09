// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введите число a");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB * numB == numA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

Console.WriteLine("Введите целое число");
string number = Console.ReadLine();
if (number == "1")
{
    Console.WriteLine("Понедельник");
}
else if (number == "2")
{
    Console.WriteLine("Вторник");
}
else if (number == "3")
{
    Console.WriteLine("Среда");
}
else if (number == "4")
{
    Console.WriteLine("Четверг");
}
else if (number == "5")
{
    Console.WriteLine("Пятница");
}
else if (number == "6")
{
    Console.WriteLine("Суббота");
}
else if (number == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Такого дня недели не существует!)");
}