// Напишите программу, которая 
// 1.принимает на вход цифру, обозначающую день недели, и 
// 2.проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

 Console.WriteLine ("Введите день недели...");
int dayOfWeek = int.Parse (Console.ReadLine());
if (dayOfWeek == 6 || dayOfWeek == 7) 
Console.WriteLine ("Ответ: Да.");
else if (dayOfWeek <= 5) 
Console.WriteLine ("Ответ: Нет.");
else if (dayOfWeek > 7) 
Console.WriteLine ("Ошибка: В неделе всего 7 дней!");


