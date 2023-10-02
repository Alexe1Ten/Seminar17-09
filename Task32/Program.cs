// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
    int[] reversArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        reversArr[i] = arr[i] * (-1);
    }
    return reversArr;
}

int[] rndArr = RandomArray(-9, 9, 8);
int[] revArr = ReversArray(rndArr);
Console.WriteLine($"[{string.Join(", ",rndArr)}] -> [{string.Join(", ",revArr)}]");

