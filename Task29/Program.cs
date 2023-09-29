// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Input()
{
    return Convert.ToInt32(Console.ReadLine());
}

int [] Array(int count)
{
    int [] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите элемент {i+1}");
        arr[i] = Input();
    }
    return arr;
}

Console.WriteLine("Сколько должно быть элементов в массиве?");
int countElements = Input();

int [] result = Array(countElements);
Console.WriteLine($"[{string.Join(",", result)}]");


