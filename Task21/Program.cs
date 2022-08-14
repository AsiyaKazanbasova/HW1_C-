// Задача 21. Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter x1 coordinate: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter x2 coordinate: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter y1 coordinate: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter y2 coordinate: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter z1 coordinate: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter z2 coordinate: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));

Console.WriteLine($"Distance between coordinate points: {result:f2}");