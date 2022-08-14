// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.Clear();

Console.WriteLine("Enter x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter y1");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter x2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter y2");
int y2 = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

Console.WriteLine("\n" + AB.ToString("N2"));