// Напишите программу, которая на вход принимает число и выдаёт, 
// 1.является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Является ли число четным");
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) Console.WriteLine("Да");   
else Console.WriteLine("Нет");



