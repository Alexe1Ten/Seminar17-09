// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

try
{
    Console.WriteLine("Введите число N: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = "";
    for (int i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            if (i == num || i == num - 1)
            {
                result += i;
            }
            else
            {
                result += i + ", ";
            }
        }
    }
    Console.WriteLine($"{num} -> {result}");
}
catch (System.FormatException)
{
    Console.WriteLine("Ошибка ввода! Вы ввели не целое число.");
}

