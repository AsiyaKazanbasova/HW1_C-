﻿// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.Write(Math.Round(array[i], 2) + " ");
}
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    else if (array[i] > max) max = array[i];
}
double diff = max - min;
Console.WriteLine($"Difference between maximum and minimum elements is: {diff}");