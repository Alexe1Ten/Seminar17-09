// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool NumInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int InputNum(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = RandomArray(1, 9, 8);
int findNum = InputNum("Введите число: ");
Console.Write($"{findNum}; массив [{string.Join(", ", array)} -> ]");
Console.WriteLine(NumInArray(array, findNum) ? "да" : "нет");

