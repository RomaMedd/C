/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


void SumPrint(int m, int n)
{
 Console.Write(Sum(m - 1, n));
}

int Sum(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + Sum(m, n);
        return result;
    }
}
 
Console.Write("Введите число минимальное число M: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число максимальное число N: ");
int max = Convert.ToInt32(Console.ReadLine());

SumPrint(min, max);