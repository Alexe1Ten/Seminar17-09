// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int InputNum(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int CountElementsInArray(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) count++;
    }
    return count;
}

int[] array = RandomArray(1, 99, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");

int minNum = InputNum("Введите начало диапозона для поиска: ");
int maxNum = InputNum("Введите конец диапозона для поиска: ");
int countElements = CountElementsInArray(array, minNum, maxNum);
Console.WriteLine($"[{string.Join(", ", array)}] -> {countElements}");


