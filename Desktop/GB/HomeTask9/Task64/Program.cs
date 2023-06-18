// //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Вариант 1.
//  Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// NaturalNumbers(number);

// void NaturalNumbers(int num)
// {
//     Console.Write($"{num} ");
//     if (num == 1) return;
//     NaturalNumbers(num - 1);
// } 

// Вариант 2.
Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbersRange(numberM, numberN);

void NaturalNumbersRange(int numM, int numN)
{
    if (numM > numN)
    {
        NaturalNumbersRange(numM - 1, numN);
        Console.Write($" {numM}");
    }
    else if (numM < numN)
    {
        NaturalNumbersRange(numM + 1, numN);
        Console.Write($" {numM}");
    }
    else Console.Write($" {numM}");
}