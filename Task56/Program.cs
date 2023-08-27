
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMartixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],+5}");

        }
        Console.WriteLine("| ");
    }

}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

    Console.WriteLine("]");
}

int[] SumElemRowMatrix(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] = matrix[i, j] + sum[i];
        }
    }

    return sum;
}
int PrintRowMinSum(int[] array)
{
    int min_sum = array[0];
    int num = 1;
    for (int i = 1; i < array.Length; i++)
    {  if (array[i] <= min_sum)
        {
            min_sum = array[i];
            num = i + 1;

        }

    }

    return num;
}


int[,] array_2d = CreateMartixRndInt(4, 4, 1, 30);
PrintMatrix(array_2d);
Console.WriteLine();
int[] arr = SumElemRowMatrix(array_2d);
PrintArray(arr);
int number = PrintRowMinSum(arr);
Console.WriteLine($"Номер строки с наименьшей суммой элементов = {number}");