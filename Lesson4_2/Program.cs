//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

class Program
{
    static int Sum(int value)
    {
        if (value < 10)
        return value;

        int remains = value % 10;

        int nvalue = value / 10;

        return remains + Sum(nvalue);

    }

    static void PrintResult(int result1)
    {
        Console.WriteLine("Результаты вычеслений = " + result1);
    }
    static void Main (string[] args)
    {
        int numbers = Int32.Parse(Console.ReadLine());
        int result = Sum(numbers);
        PrintResult(result);
    }

}

