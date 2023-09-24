// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка [10, 99] -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"наибольшую цифру числа -> {firstDigit}");
// else Console.WriteLine($"наибольшую цифру числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"наибольшую цифру числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшую цифру числа -> {maxDigit}");
