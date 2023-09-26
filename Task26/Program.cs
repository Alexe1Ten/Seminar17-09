// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 


int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}

int NumberOfDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int num = Input();
int result = NumberOfDigits(num);
Console.WriteLine($"{num} -> {result}");

