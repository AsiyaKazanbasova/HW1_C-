// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter number M please: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N please: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) return;

int SumNumbers(int start, int end)
{
    if (start == end) return start;
    return (start + SumNumbers(start + 1, end));
}
Console.WriteLine($"Sum of natural elements between {M} and {N} is: '{SumNumbers(M, N)}' ");