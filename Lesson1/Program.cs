//Задание №1  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = 5;
int b = 7;
int max = 0;
int min = 0;

if (a > b )
{
    max = a;
    min = b;
    Console.Write ("max = ");
    Console.WriteLine (a);

    Console.Write ("min = ");
    Console.WriteLine (b);
}
else 
{
    max = b;
    min = a;
    Console.Write ("min = ");
    Console.WriteLine (a);

    Console.Write ("max = ");
    Console.WriteLine (b);
}