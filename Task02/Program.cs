// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
try
{
    Console.WriteLine("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine($"a = {a}; b = {b} -> min = {b}; max = {a}");
    }
    else
    {
        Console.WriteLine($"a = {a}; b = {b} -> min = {a}; max = {b}");
    }
}
catch (System.FormatException)
{
    Console.WriteLine("Ошибка ввода! Вы ввели не число.");
}
