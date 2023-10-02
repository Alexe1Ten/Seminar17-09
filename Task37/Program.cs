// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

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

int[] ProductOfPairsOfNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] powArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        powArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (size % 2 != 0) powArray[size - 1] = arr[size - 1];
    return powArray;
}

int[] rndArr = RandomArray(1, 9, 6);
int[] newArr = ProductOfPairsOfNumbers(rndArr);

Console.WriteLine($"[{string.Join(", ", rndArr)}] -> [{string.Join(", ", newArr)}]");


