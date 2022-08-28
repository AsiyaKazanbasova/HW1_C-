// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter b1 coeficient: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter k1 coeficient: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter b2 coeficient: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter k2 coeficient: ");
int k2 = Convert.ToInt32(Console.ReadLine());

void CrossPointLines(double k1, double b1, double k2, double b2)
{
double x = (b2 - b1) / (k1 - k2);
double y = (k1 * b2 - k1 * b1) / (k1 - k2) + b1;

if(k1 == k2) Console.Write("Given lines do not intersect!");
else
Console.Write($"Point of intersection of given lines: ({x}; {y})");
}
CrossPointLines(k1, b1, k2, b2);