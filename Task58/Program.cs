// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Enter a number of rows of the first matrix (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns of the first (as well as a number of rows of the second) matrix (n): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns of the second matrix (p)): ");
int p = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] firstMatrix = new int[m, n];
FillArray(firstMatrix);
Console.WriteLine($"\n First matrix:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
FillArray(secondMatrix);
Console.WriteLine($"\n Second matrix:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m, p];

ProductMatrices(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\n Product of the first and second matrices:");
PrintArray(resultMatrix);

void ProductMatrices(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}