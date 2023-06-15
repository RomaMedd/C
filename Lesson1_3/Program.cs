//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
int i = 0;
int a = 0;
int x = Int32.Parse(Console.ReadLine());

while (i < x - 1)
{
    i = i + 2;
    Console.Write(i);
    Console.Write(", ");
}