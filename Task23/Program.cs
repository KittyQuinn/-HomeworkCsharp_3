// Задача 23
// Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27

Console.Clear();
Console.WriteLine("Type number ");
int num = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= num ; i++)
Console.WriteLine(Math.Pow(i, 3));
