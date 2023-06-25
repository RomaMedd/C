//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

class Program
{
    static double degree (int number1, int number2)
    {
        int index = 0;
        double result = 0;
        while (index < number2)
        {
            result = Math.Pow(number1, number2);
            index++;
        }
        return result;
    }
    static void PrintResult(double result)
    {
        Console.WriteLine("Результаты вычеслений = " + result);
    }
    static void Main (string[] args)
    {
        int a, b;
        double c;
        Console.Write("Введите число number1: ");
        a = Int32.Parse(Console.ReadLine());
        Console.Write("Введите число number2: ");
        b = Int32.Parse(Console.ReadLine());

        c = degree(a, b);

        PrintResult(c);
    }

}
