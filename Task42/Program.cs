// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int BinNum(int num)
{
    int result = 0;
    int temp = 1;
    while (num > 0)
    {
        result += num % 2 * temp;
        num /= 2;
        temp *= 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int binNumber = BinNum(number);
Console.WriteLine(binNumber);



