// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
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

int[,] arrayUnsorted = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine("Первоначальный массив:");
PrintArray(arrayUnsorted);
Console.WriteLine();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        int minPosition = j;
        for (int k = j + 1; k < columns; k++)
        {
            if (arrayUnsorted[i, k] < arrayUnsorted[i, minPosition])
            {
                minPosition = k;
            }
        }
        int temp = arrayUnsorted[i, j];
        arrayUnsorted[i, j] = arrayUnsorted[i, minPosition];
        arrayUnsorted[i, minPosition] = temp;
        Console.Write(arrayUnsorted[i, j] + "\t");
    }
    Console.WriteLine();
}
