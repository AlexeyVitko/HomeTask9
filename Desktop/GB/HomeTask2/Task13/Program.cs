// Задача 13: Напишите программу, которая выводит 
// 1. третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) number = number*(-1);
if (number>=0 && number<100) Console.WriteLine("Введенная цифра не имеет третьего разряда");  

else
{
int Result = result(number);
Console.WriteLine($"Третий разряд числа => {Result}");
}

int result (int num)
{
while (num>999)
{
    num=num/10;
}
return num%10;
}