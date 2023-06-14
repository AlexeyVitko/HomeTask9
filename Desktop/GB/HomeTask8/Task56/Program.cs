// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;
int columns = 4;
int[,] array2d = CreateMatrixRndInt(rows, columns, 0, 100);
PrintMatrix(array2d);

int[] sumaOfElementsRows = SumaOfElementsRows(array2d);
Console.WriteLine();

 int numberMinSumElemets = NumberMinSumElemets(sumaOfElementsRows);  
Console.WriteLine($"Номер строки с минимальной суммой каждого элемента строки = {numberMinSumElemets}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
        Console.Write(i + "|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[] SumaOfElementsRows(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int NumberMinSumElemets(int[] arr)
{
    int numbindex = 0;
    int min = arr[0];
    int i =0;
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            numbindex = i;
        } 
    }
    return numbindex;
}
