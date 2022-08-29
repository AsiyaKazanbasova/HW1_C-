// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1, 10)
        }
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);

Console.Write("Enter a number for row position: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number for column position: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());

if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
{
    Console.Write("There is no such number in a given two-dimensional array!");
}
Console.Write($"Array element value at positions {rowPosition} and {columnPosition} is: {matrix[rowPosition, columnPosition]}");