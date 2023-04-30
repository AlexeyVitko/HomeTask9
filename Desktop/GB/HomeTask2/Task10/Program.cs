// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    Console.WriteLine("Введено трехзначное число");
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа => {secondDigit}");
}

else
{
    Console.WriteLine("Введено не трехзначное число, замените число на другое");
}

int SecondDigit(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}
int SecondDigit(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}
