// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

double[] RandomDoubleArray(int ratio, int length)
{
    double[] arr = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * ratio, 2);
    }
    return arr;
}

double DiffBetweenMaxAndMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    return Math.Round(max - min, 2);
}

double[] randArray = RandomDoubleArray(100, 8);
Console.WriteLine($"[{string.Join(", ", randArray)}]");
double diffBetweenMaxAndMin = DiffBetweenMaxAndMin(randArray);

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива равна {diffBetweenMaxAndMin}");

