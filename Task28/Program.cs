// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}

int ProductOfNumbers(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number = Input();
int result = ProductOfNumbers(number);

Console.WriteLine($"{number} -> {result}");




