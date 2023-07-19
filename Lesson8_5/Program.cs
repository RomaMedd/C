/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int len = 4;
int[,] matrix = new int[len, len];
FillArray(matrix, len);
PrintArray(matrix);


void FillArray(int[,] matr, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int x = 0;
        do { matr[i, j++] = value++; } while (++x < n - 1);
        for         (x=0;x<n-1;x++) matr[i++, j]  =value++;
        for         (x=0;x<n-1;x++) matr[i,   j--]=value++;
        for         (x=0;x<n-1;x++) matr[i--, j]  =value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
 Console.Write("0" + matr[i, j]);
 Console.Write( " ");
            }
            else Console.Write(matr[i, j] + " ");
        }
 Console.WriteLine();
    }
}