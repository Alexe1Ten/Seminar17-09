// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers (int numM, int numN)
{
    if(numM == numN) 
    {
        int sum = numM;
        return sum;
    }
    else if (numM > numN)
    {
        int sum = numN;
        return sum += SumNaturalNumbers (numM - 1, numN);
    }
    else 
    {
        int sum = numM;
        return sum += SumNaturalNumbers (numM + 1, numN);
    }
}

Console.WriteLine("Введите первое натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

Console.WriteLine($"M = {m}; N = {n} -> {SumNaturalNumbers(m, n)}");