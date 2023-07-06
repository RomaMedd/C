/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9*/


void PrintArray(double[,] matr)
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
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

Console.Write("Введите количество строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double[i, j];

FillArray(matrix);
PrintArray(matrix);