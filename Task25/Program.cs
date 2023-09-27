// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a; 
    }
    return result;
}

Console.WriteLine("введите число А: ");
int numA = Input();
Console.WriteLine("Введите число В: ");
int numB = Input();

int res = Exponentiation(numA, numB);
Console.WriteLine($"{numA}, {numB}, -> {res}");


