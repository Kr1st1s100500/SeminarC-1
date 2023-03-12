﻿// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} : {Sum(number, sumNumbers)}");

int SumNumbers(int num)
{
    int index = 0;
    while (num > 0)
{
num/=10;
index++;
}
return index;
}
int Sum(int num, int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
      sum += num % 10;
      num/=10; 
    }
    return sum;
}
