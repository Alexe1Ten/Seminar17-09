// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit (int num)
{
    return num / 10 % 10;
}

Console.WriteLine("Введите 3х значное число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
if (inputNumber > 999 || inputNumber < 100)
{
    Console.WriteLine("Ошибка! Вы ввели не 3х значиное число! Попробуйте еще раз");
}
else
{
    int secondDigit = SecondDigit(inputNumber);
    Console.WriteLine($"{inputNumber} -> {secondDigit}");
}



