// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int Input()
{
    return Convert.ToInt32(Console.ReadLine());
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

Console.WriteLine("Сколько должно быть элементов в массиве?");
int quan = Input();
Console.WriteLine("С какого числа начинаем?");
int fr = Input();
Console.WriteLine("Каким числом заканчиваем?");
int bef = Input();

int [] result = ArrayOfRandom(fr, bef, quan);
Console.WriteLine($"[{string.Join(",", result)}]");

