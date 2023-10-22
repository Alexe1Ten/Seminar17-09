// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int FuncAck(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return FuncAck(numM-1, 1);
    else return FuncAck(numM - 1, FuncAck(numM, numN - 1));
}

Console.WriteLine("Введите первое неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}

Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {FuncAck(m, n)}");