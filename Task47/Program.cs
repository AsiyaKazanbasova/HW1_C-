// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Enter a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 100;
        }
    }
    return matrix;
}
double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(inputMatrix[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}