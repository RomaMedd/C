/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

void Sum(int[,] matr)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
            rowSum += matr[i, j];

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow = i;
        }
    }
    Console.WriteLine("Строка с минимальной суммой элементов");

    Console.Write(indexMinRow + 1);
}

Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[line, column];

FillArray(matrix);
PrintArray(matrix);
Sum(matrix);

