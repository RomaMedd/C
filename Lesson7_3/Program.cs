/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Average(int[,] matr)
{
    double[] Average = new double[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        double aver = 0.0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            aver = aver + matr[i, j];
        }
        Average[i] = aver / matr.GetLength(0);
    }
    PrintArrayAver(Average);    
}

void PrintArrayAver(double[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write(matr[i] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите количество строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j];

FillArray(matrix);
PrintArray(matrix);
Average(matrix);

