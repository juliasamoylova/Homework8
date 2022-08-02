// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
Console.Write("Задайте количество строк массивов:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массивов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте минимальное число в массивых:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальное число в массивах:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] arrayFirst = GetArray(rows, columns, minValue, maxValue);
int[,] arraySecond = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine("Первый массив:");
PrintArray(arrayFirst);
Console.WriteLine();
Console.WriteLine("Второй массив:");
PrintArray(arraySecond);
Console.WriteLine();
Console.WriteLine("Произведение массивов:");
int[,] arrayMultiplication = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arrayMultiplication[i, j] = arrayFirst[i, j] * arraySecond[i, j];
        Console.Write(arrayMultiplication[i, j] + "\t");
    }
    Console.WriteLine();
}

