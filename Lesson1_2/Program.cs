//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int x = Int32.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    Console.Write("Четное = ");
    Console.WriteLine(x);
}
else
{
    Console.Write("Нечетное = ");
    Console.WriteLine(x);
}