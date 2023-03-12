// Напишите программу, которая на вход 
// 1.принимает число (N), а 
// 2.на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

for ( int A = 1; A <= n; A++)
{
    if (A % 2 == 0)
    
        Console.Write(A + " ");
       

}