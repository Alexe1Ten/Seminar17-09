// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}

int SummDigits(int num)
{
    int res = 0;
    while (num != 0)
    {
        res += num % 10;
        num /= 10; 
    }
    return res;
}

Console.WriteLine("Введите чсило: ");
int number = Input();

int result = SummDigits(number);

Console.WriteLine($"{number} -> {result}");


