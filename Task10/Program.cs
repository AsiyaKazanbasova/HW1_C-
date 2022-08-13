// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter any of three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = (number / 10) - (number / 100) * 10;
Console.WriteLine($"The second digit of {number} is {result}");