// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


// void Square (int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.WriteLine($"{i, 3} -> {i * i, 5}");
//     }
// }


// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Square(n);


static bool IsPalindrome(int number)
{
    int temp = 0;
    int revNumber = 0;
    int num = number;
    while (num != 0)
    {
        temp = num % 10;
        num = num / 10;
        revNumber = revNumber * 10 + temp;
    }
    if (number == revNumber) return true;
    else return false;
}
int ss = 12321;
bool x = IsPalindrome(ss);

if (ss < 10000 || ss > 99999)
{
    Console.WriteLine($"Число не пятизначное {false}");
}
else 
{
    Console.WriteLine(x);
}





