// Напишите программу, которая принимает на вход 
// 1.три числа и 
// 2.выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Максимальное число из трех чисел");
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int С = Convert.ToInt32(Console.ReadLine());
int max = A;
if (B > max) max = B;
if (С > max) max = С;
Console.WriteLine("max = ");
Console.WriteLine(max);