Console.WriteLine("Введите число a");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB * numB == numA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
