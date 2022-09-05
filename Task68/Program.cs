// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Enter number for m please: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number for n please: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) return;

int Ackermann(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if ((numberM > 0) && (numberN == 0)) return Ackermann(numberM - 1, 1);
    return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
}
Console.WriteLine($"Ackermann function of ({m}, {n}) is: '{Ackermann(m, n)}' ");