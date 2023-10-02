// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
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

int SummInArray(int[] arr, bool positive)
{
    int sum = 0;
    if (positive)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) sum += arr[i];
        }
    }
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0) sum += arr[i];
        }
    }
    return sum;
}

int[] randArr = RandomArray(-9, 9, 12);
int sumPositive = SummInArray(randArr, true);
int sumNegative = SummInArray(randArr, false);

Console.WriteLine($"[{string.Join(", ", randArr)}]");
Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");

