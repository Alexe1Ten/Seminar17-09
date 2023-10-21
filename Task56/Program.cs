// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[row, i];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int[] res = new int[2];
    int sum = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSum += matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            res[0] = i;
        } 
    }
    res[1] = minSum;
    return res;
}

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


int[,] rndMatrix = CreatMatrixRandomInt(3, 3, 1, 9);
PrintArray(rndMatrix);

Console.WriteLine();
int[] resSum = MinimumSumRow(rndMatrix);
Console.WriteLine($"{string.Join(", ", resSum)}");
int result = SumOfRow(rndMatrix, resSum[0]);
Console.WriteLine(result);