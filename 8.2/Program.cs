// See https://aka.ms/new-console-template for more information
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Задайте количество строк массивов:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массивов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте минимальное число в массивых:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальное число в массивах:");
int maxValue = Convert.ToInt32(Console.ReadLine());
while (rows == columns)
{
    Console.WriteLine("Массив не прямоугольный, введите заново");
    Console.Write("Задайте количество строк массивов:");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцов массивов:");
    columns = Convert.ToInt32(Console.ReadLine());
    break;
}

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

int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();
int[] sumArray = new int[rows];
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum = sum + array[i, j];
    }
    Console.WriteLine($"Сумма элементов строки {i + 1} равна {sum}");
    // int[] sumArray = new int[rows];
    sumArray[i] = sum;
}
for (int i = 0; i < rows; i++)
{
    Console.Write(sumArray[i] + "\t");
}
Console.WriteLine();

int indexMin = Array.IndexOf(sumArray, sumArray.Min());
Console.WriteLine($"Номер строки с минимальной суммой значений:{indexMin + 1}");











//     {
//         int minPosition = j;
//         for (int k = j + 1; k < columns; k++)
//         {
//             if (arrayUnsorted[i, k] < arrayUnsorted[i, minPosition])
//             {
//                 minPosition = k;
//             }
//         }
//         int temp = arrayUnsorted[i, j];
//         arrayUnsorted[i, j] = arrayUnsorted[i, minPosition];
//         arrayUnsorted[i, minPosition] = temp;
//         Console.Write(arrayUnsorted[i, j] + "\t");
//     }
//     Console.WriteLine();
// }