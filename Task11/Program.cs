// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



int Func (int num)
{
    return num / 100 * 10 + num % 10;
}

int number = new Random().Next(100,1000);
Console.WriteLine($"Трехзначное число -> {number}");

int x = Func(number);
Console.WriteLine($"Двухзначное число -> {x}");
Console.WriteLine($"Двухзначное число -> {Func(number)}");