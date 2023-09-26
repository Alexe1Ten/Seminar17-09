// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).


string QuaterToCoords(int quadr)
{
    if(quadr == 1) return "x > 0, y > 0";
    if(quadr == 2) return "x < 0, y > 0";
    if(quadr == 3) return "x < 0, y < 0";
    if(quadr == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Input quater");

Console.Write("quater: ");
int quater = Convert.ToInt32(Console.ReadLine());

string result = QuaterToCoords(quater);

Console.WriteLine((result != null) ? result : "user did not input quater number");

// double d = 5.099984343; // 5.09
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(dRound);
// Math.Pow(4, 6);
// Math.Sqrt(5);