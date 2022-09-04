// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Enter a number of rows of the cube: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of columns of the cube: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of depth of the cube: ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] cube = new int[rows, columns, depth];
FillArray(cube);
PrintArray(cube);

void PrintArray(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] cube)
{
    int[] temporary = new int[cube.GetLength(0) * cube.GetLength(1) * cube.GetLength(2)];
    int number;
    for (int i = 0; i < temporary.GetLength(0); i++)
    {
        temporary[i] = new Random().Next(10, 100);
        number = temporary[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temporary[i] == temporary[j])
                {
                    temporary[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temporary[i];
                }
                number = temporary[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < cube.GetLength(0); x++)
    {
        for (int y = 0; y < cube.GetLength(1); y++)
        {
            for (int z = 0; z < cube.GetLength(2); z++)
            {
                cube[x, y, z] = temporary[count];
                count++;
            }
        }
    }
}