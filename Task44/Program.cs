// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci(int num)
{
    int[] fibonacci = new int[num];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
    }
    for (int j = 0; j < num; j++)
    {
        Console.Write($"{fibonacci[j]} ");
    }
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Fibonacci(n);
