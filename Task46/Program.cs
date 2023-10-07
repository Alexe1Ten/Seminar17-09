// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] RandomNumberInMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(-99, 100);
        }
    }
    return result;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0}\t",arr[i,j]);
        }
        Console.WriteLine();
    }
}

int[,] randomMatrix = RandomNumberInMatrix(3, 4);
PrintMatrix(randomMatrix);
