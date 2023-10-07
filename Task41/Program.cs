// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int PositiveNumberCounter(int m)
{
    int count = 0;
    for (int i = 1; i < m; i++)
    {
        Console.Write("Введите число: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел М: ");
int mNum = Convert.ToInt32(Console.ReadLine());

int positiveNumberCounter = PositiveNumberCounter(mNum);
Console.WriteLine($"Вы ввели {positiveNumberCounter} положительных числа");

