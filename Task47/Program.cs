// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    Random rnd = new();
    double[,] rndArr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            rndArr[i, j] = Math.Round(rnd.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom, 1);
        }
    }
    return rndArr;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 7}");
        }
        Console.WriteLine();
    }
}

double[,] randomMatrix = CreateRandomMatrix(3, 4, -10, 10);
PrintMatrix(randomMatrix);
