/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int OutputOfNumbers(int n)
{
    if (n == 1)
    {
        Console.Write(n);
        return n;
    }
    else
    {

        Console.Write($"{n}, ");
        return OutputOfNumbers(n - 1);
    }


}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Натуральные числа в промежутке от {number} до 1 = ");
OutputOfNumbers(number);
