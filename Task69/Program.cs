// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Factorial(int a, int b)
// {
//     if (b == 0) return 1;
//     return a * Factorial(a, b - 1);
// }
// Console.WriteLine(Factorial(2, 3));

// double[] array = new double[] {-3,2,4};

// void sortSquare(double[] arr)
// {
//     double temp = Math.Pow(arr[0], 2);
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (Math.Pow(arr[i], 2) < temp) arr[i - 1] = Math.Pow(arr[i], 2);
//         else arr[i - 1] = temp;
//         temp = Math.Pow(arr[i], 2);
//     }
// }

// Console.WriteLine($"{string.Join(", ", array)}");

// sortSquare(array);
// Console.WriteLine($"{string.Join(", ", array)}");
int[,] CreatMatrixRandomInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0}\t", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

void SortRowsDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > temp)
            {
                matrix[i, j - 1] = matrix[i, j];
                matrix[i, j] = temp;
            }
            else
            {
                matrix[i, j - 1] = temp;
                temp = matrix[i, j];
            }

        }
    }
}

int[,] rndMatrix = CreatMatrixRandomInt(3, 3, 1, 9);
PrintArray(rndMatrix);
Console.WriteLine();

SortRowsDescending(rndMatrix);
PrintArray(rndMatrix);