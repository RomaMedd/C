/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] + " ";
    }
    return res;
}

int SumPositiveNumbs(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 0)
        sum += array[i];
    return sum;
}



int minValue = -1000;
int maxValue = 1000;

int[] myArray = new int[5];
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
int pos = SumPositiveNumbs(myArray);


Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {pos}");
