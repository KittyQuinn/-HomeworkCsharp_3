// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Type 5-digit number ");
int num = int.Parse(Console.ReadLine());

string str = num.ToString();

if ((str[0] == str[4]) & (str[1] == str[3]))
Console.WriteLine("Yes");

else
Console.WriteLine("No");
