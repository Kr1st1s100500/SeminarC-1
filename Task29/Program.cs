//  Напишите программу, которая 
//  1. задаёт массив из 8 элементов и 
//  2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void FillArray(int[] arr)
{   
    Random rmd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rmd.Next(0, 100);

    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {   
    if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }

}
void PrintArray1(int[] arr)
{
    Console.Write($" -> [ ");
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {   
   if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
     Console.Write($" ]");

}

FillArray(array);
PrintArray(array);
PrintArray1(array);