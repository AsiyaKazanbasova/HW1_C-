// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int GetDigitsSum(int num)
{
    int sum = 0;
    int i = 0;
    while (number > 0)
    {
        number /=10;
        sum += number;
        i++;
    }
    return sum;
}
Console.WriteLine($"Digits sum of {number} = {GetDigitsSum(number)}");