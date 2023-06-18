
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру, обозначающую день недели");
int week = Int32.Parse(Console.ReadLine());
if (week > 7)
{
    Console.WriteLine("Введите цифру от 1 до 7");
}
else
{
    if (week > 5)
    {
        Console.WriteLine("Да, выходной");
    }
    else
        Console.WriteLine("Нет, будни");
}