// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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
bool ChangeMatrix(int[,] matrix_A, int[,] matrix_B)
{
    return matrix_A.GetLength(0) == matrix_B.GetLength(1);
}

int[,] MultiplicatiomTwoMatrix(int[,] matrix_A, int[,] matrix_B)
{

    int[,] matrix_multi = new int[matrix_A.GetLength(0), matrix_B.GetLength(1)];

    for (int i = 0; i < matrix_multi.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_multi.GetLength(1); j++)
        {
            int summ = 0;
            for (int k = 0; k < matrix_A.GetLength(1); k++)
            {

                summ = summ + matrix_A[i, k] * matrix_B[k, j];
            }
            matrix_multi[i, j] = summ;
        }

    }
    return matrix_multi;
}

int[,] array_2d_A = CreateMartixRndInt(2, 2, 1, 3);

int[,] array_2d_B = CreateMartixRndInt(2, 2, 1, 3);

if (!ChangeMatrix(array_2d_A,array_2d_B)) {
Console.WriteLine("Невозможно перемножить матрицы!");
return;}
PrintMatrix(array_2d_B);
Console.WriteLine();
PrintMatrix(array_2d_A);
Console.WriteLine();
int[,] multi_matrix = MultiplicatiomTwoMatrix(array_2d_A, array_2d_B);
PrintMatrix(multi_matrix);

