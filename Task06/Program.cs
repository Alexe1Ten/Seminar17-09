// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

try
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}
catch (System.FormatException)
{
    Console.WriteLine("Ошибка ввода! Вы ввели не целое число.");
}
