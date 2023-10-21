// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int max = matrix[i, j];
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > max)
                {
                    max = matrix[i, k];
                    matrix[i, k] = matrix[i, j];
                    matrix[i, j] = max;
                }
            }
        }
    }

}

int[,] rndMatrix = CreatMatrixRandomInt(3, 3, 1, 9);
PrintArray(rndMatrix);

Console.WriteLine();
SortRowsDescending(rndMatrix);
PrintArray(rndMatrix);