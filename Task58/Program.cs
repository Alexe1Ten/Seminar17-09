// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("It is impossible to multiply.");
        return;
    }
    PrintArray(MatrixMultiplication(matrixA, matrixB));
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] res = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int pow = 1;
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                pow = matrixA[i, k] * matrixB[k, j];
                sum += pow;
            }
            res[i, j] = sum;
        }
    }
    return res;
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

int[,] matrixB = {
            {5, 6},
            {7, 8},
            {3, 4}
        };

int[,] matrix = new int[,]
            {
                {1, 2},
                {3, 4},
                {3, 4}
            };

PrintArray(matrix);
Console.WriteLine();

PrintArray(matrixB);
Console.WriteLine();

MultiplyIfPossible(matrix, matrixB);