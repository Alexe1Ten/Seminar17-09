// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
try
{
    string result = "";
    int max = 0;
    for (int i = 1; i < 4; i++)
    {
        Console.WriteLine($"Введите число {i}: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (i == 1)
        {
            max = temp;
        }
        if (temp > max)
        {
            max = temp;
        }
        result += temp.ToString() + " ";
    }
    Console.WriteLine($"{result}-> max = {max}");
}
catch (System.FormatException)
{
    Console.WriteLine("Ошибка ввода! Вы ввели не целое число.");
}
