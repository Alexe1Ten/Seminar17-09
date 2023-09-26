// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


void Square (int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i, 3} -> {i * i, 5}");
    }
}


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Square(n);







