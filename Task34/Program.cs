// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1000);
    Console.Write(array[i] + " ");
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] %2 == 0) count++;
}
Console.WriteLine($"The amount of even numbers in the array is: {count}");