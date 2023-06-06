// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение B1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число K1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение B2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число K2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-B2 + B1)/(-K1 + K2);
double y = K2 * x + B2;

Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}, Y: {y}");