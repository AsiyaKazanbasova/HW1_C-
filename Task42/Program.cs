// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Enter any decimal number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

int GetBinaryNumber(int binaryNumber)
{
    int result = 0;
    while (decimalNumber < 2)
    {
        result += decimalNumber % 2;
        binaryNumber /= 2;
    }
    return result;
}
Console.WriteLine($"Decimal number {decimalNumber} converted to binary = {GetBinaryNumber(decimalNumber)}");