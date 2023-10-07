// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int [] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

int [] rndArr = RandomArray(1,9,8);
Console.WriteLine($"[{string.Join(", ", rndArr)}]");

int[] copyArray = CopyArray(rndArr);
Console.WriteLine($"[{string.Join(", ", copyArray)}]");
