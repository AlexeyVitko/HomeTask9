// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows1 = 4;
int columns1 = 4;
int[,] array2d1 = CreateMatrixRndInt1(rows1, columns1, 0, 100);
PrintMatrix(array2d1);
Console.WriteLine();

int rows2 = 4;
int columns2 = 4;
int[,] array2d2 = CreateMatrixRndInt2(rows2, columns2, 0, 100);
PrintMatrix(array2d2);
Console.WriteLine();

Console.WriteLine("Матрица, полученная при переумножении Матрицы1 и Матрицы2 :");
int[,] multiplicationMatrix = MultiplicationMatrix(array2d1, array2d2);
PrintMatrix(multiplicationMatrix);

int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
{
    int[,] matrix1 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1;
}

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(i + "|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    {
        int[,] newMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                for (int z = 0; z < matr2.GetLength(0) - 1; z++)
                {
                    newMatrix[i, j] += matr1[i, z] * matr2[z, j];
                }
            }
        }
        return newMatrix;
    } 
}
