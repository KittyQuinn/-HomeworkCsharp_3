// Задача 21 Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

Console.Clear();
Console.WriteLine("Type A(x,y,z)");
Console.WriteLine("x= ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("y= ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("z= ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Type B(x,y,z)");
Console.WriteLine("x= ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("y= ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("z= ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine(result);