// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Enter any decimal number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

void ConvertToBin(int binaryNumber)
{
    if (binaryNumber == 0)
    {
        return;
    }
    ConvertToBin(binaryNumber / 2);
    Console.Write(binaryNumber % 2);
}
ConvertToBin(decimalNumber);