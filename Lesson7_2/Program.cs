/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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



Console.Write("Введите количество строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j];

FillArray(matrix);
PrintArray(matrix);

Console.Write("Введите номер столбца для поиска: ");
int y = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер строки для поиска: ");
int x = Convert.ToInt32(Console.ReadLine()) - 1;

if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
Console.WriteLine($"Значение Вашего элемента: {matrix[x, y]}");
else 
Console.WriteLine($"{x + 1}{y + 1} -> такого элемента в массиве нет");