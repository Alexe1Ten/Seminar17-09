// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

int[] RandomArray(int min, int max, int length)
{
    int[] arr = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int DiffBetweenMaxAndMin(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    return max - min;
}

int[] randArray = RandomArray(1, 99, 8);
Console.WriteLine($"[{string.Join(", ", randArray)}]");
int diffBetweenMaxAndMin = DiffBetweenMaxAndMin(randArray);

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива равна {diffBetweenMaxAndMin}");

