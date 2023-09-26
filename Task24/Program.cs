// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int Summ(int a)
{
    int summ = 0;
    for (int i = 1; i <= a; i++)
    {
        summ += i;
    }
    return summ;
}

int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите число А: ");
int num = Input();
string result = $"{num} -> {Summ(num)}";
Console.WriteLine(result);

