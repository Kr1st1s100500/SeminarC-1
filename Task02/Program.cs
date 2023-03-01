//  Напишите программу, которая на вход принимает два числа и выдаёт, 
// 1.какое число большее, 
// 2.а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Какое число является большим,а какое меньшим");
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max) max = numberB;
int min = numberA;
if (numberB < min) min = numberB;
Console.WriteLine("max = ");
Console.WriteLine(max);
Console.WriteLine("min = ");
Console.WriteLine(min);
 
