// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int GetSumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /=10;
    }
    return sum;
}
Console.WriteLine($"Digits sum of {number} = {GetSumDigits(number)}");