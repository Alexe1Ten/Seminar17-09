// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

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

int CountOfEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}

int[] rndArray = RandomArray(100, 999, 8);
Console.WriteLine($"[{string.Join(", ", rndArray)}]");
int countOfEvenNum = CountOfEvenNumbers(rndArray);
Console.WriteLine($"Количество четных чисел равна {countOfEvenNum}");





