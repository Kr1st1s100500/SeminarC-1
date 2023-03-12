// Напишите цикл, который
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(numberA, numberB);
Console.WriteLine($"{result}");

int Exponentiation(int numA, int numB)
{
    int res = 1;
    for (int i = 0; i < numB; i++)
    {
        res = res * numA;
    }
    return res;
}


