// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент)
// и возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.
// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns 
// и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", 
// где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой 
// (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] result = new int[n, m];
    int temp = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = temp;
            temp += k;
        }
    }
    return result;
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

double[] FindAverageInColumns(int[,] matrix)
{
    double[] res = new double[matrix.GetLength(1)];
    double sum = 0;
    double mean = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        mean = 0;
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += Convert.ToDouble(matrix[j, i]);
        }
        mean = sum / matrix.GetLength(0);
        res[i] = Math.Round(mean, 2);
    }
    return res;
}

void PrintListAvr (double [] list)
{
    Console.Write("The averages in columns are: ");
    Console.Write("\n");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write("{0:f2}\t", list[i]);
    }
}

int n = 4;
int m = 5;
int k = 3;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));

