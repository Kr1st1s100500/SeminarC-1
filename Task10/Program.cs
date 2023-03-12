// Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number >= 100 && number <= 1000)

{
int secondDigit = (number % 100 - number%10)/10;
Console.WriteLine($"Вторая цифра числа -> {secondDigit}");
}
else 
Console.WriteLine("Это не трехзначное число");