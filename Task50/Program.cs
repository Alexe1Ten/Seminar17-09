// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.
// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся 
// на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
//  k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. 
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением.
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции,
//  а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.
// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. 
// Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

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
            Console.Write("{0}\t",matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int[] result = new int[2];
    if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(0)) return result;
    else result[0] = matrix[rowPosition - 1, columnPosition - 1];
    return result;
}

void PrintCheckIfError(int[] results, int X, int Y)
{
    if (results[0] == 0) Console.WriteLine("There is no such index");
    else Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
}

int n = 4;
int m = 5;
int k = 2;
int x = 3;
int y = 2;

int[,] res = CreateIncreasingMatrix(n, m, k);
PrintArray(res);
PrintCheckIfError(FindNumberByPosition(res, x, y), x, y);
