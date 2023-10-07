// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] ReversArray(int[] arr)
{
    int [] revArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        revArr[i] = arr[arr.Length - 1 - i];
    }
    return revArr;
}

int[] rndArray = RandomArray(1,9,6);
Console.WriteLine($"[{string.Join(", ", rndArray)}]");

int[] revArray = ReversArray(rndArray);
Console.WriteLine($"[{string.Join(", ", revArray)}]");

