// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter power B: ");
int powerB = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= powerB; i++)
{
    Console.WriteLine(i*i);
}
Console.WriteLine($"Result of a number A in power B: {Math.Pow(numberA, powerB)}");