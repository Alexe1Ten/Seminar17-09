// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int InputInt()
{
    return Convert.ToInt32(Console.ReadLine());
}

string InputStr()
{
    return Console.ReadLine();
}

int [] ArrayOfRandom(int from, int before, int quantity)
{
    int [] randomArr = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        randomArr[i] = new Random().Next(from, before + 1);
    }
    return randomArr;
}

int [] ArraySort(int [] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr [j] > arr[maxIndex]) maxIndex = j;
        }
        int temp = arr[i];
        arr[i] = arr[maxIndex];
        arr[maxIndex] = temp;
    }
    return arr;
}

bool Choice(string choice)
{
    if (choice == "да" || choice == "yes" || choice == "y") return true;
    else if (choice == "нет" || choice == "no" || choice == "n") return false;
}


Console.WriteLine("Сколько должно быть элементов в массиве?");
int quan = InputInt();
Console.WriteLine("С какого числа начинаем?");
int fr = InputInt();
Console.WriteLine("Каким числом заканчиваем?");
int bef = InputInt();

int [] result = ArrayOfRandom(fr, bef, quan);
Console.WriteLine($"[{string.Join(", ", result)}]");

Console.WriteLine("Отсортировать получившийся массив? да/нет");
string answer = InputStr();

if (Choice(answer)) Console.WriteLine($"[{string.Join(", ", ArraySort(result))}]");

