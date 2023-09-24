// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

bool Multiple (int x, int y)
{
    if (x % y == 0) return true;
    else return false;
}

int RemainderDivision (int x, int y)
{
    return x % y;
}


Console.WriteLine("Введите 1 число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (Multiple(firstNum,secondNum) == true)
{
    Console.WriteLine($"{firstNum}, {secondNum} -> кратно");
}
else
{
    Console.WriteLine($"{firstNum}, {secondNum} -> не кратно, остаток {RemainderDivision(firstNum,secondNum)}");
}

