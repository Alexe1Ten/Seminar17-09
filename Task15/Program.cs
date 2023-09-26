// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


string Weekend (int day)
{
    if (day == 6 || day == 7) return $"{day} -> да";
    else if (day > 0 && day < 6) return $"{day} -> нет";
    else return $"Такого дня недели не существует";
}

Console.WriteLine("Введите цифру обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekend(num));

