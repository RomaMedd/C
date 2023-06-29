/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] createArray(int size)
{
    return new double[size];
}

void FillArray(double[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max +1) + rnd.NextDouble();
    }
}

string PrintArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] + " ";
    }
    return res;
}

double searchMax(double[] array)
{
    int i = 0;
    double max = 0;
    while(max > array[i])
    {
        max = array[i];
    }
    return array[i];
}
double searchMin(double[] array)
{
    double min = 0;
    for (int i = 0; min > array[i]; i++)
    {
        min = array[i];
    }
    return min;
}

static byte[] GetBytes(double[] values)
{
    return values.SelectMany(value => BitConverter.GetBytes(value)).ToArray();
}

int size = InputNum("Введите размер массива: ");
int minValue = -1000;
int maxValue = 1000;


double[] myArray = createArray(size);
GetBytes(myArray);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
double pos = searchMax(myArray);



Console.WriteLine($"Количество положительных элементов равна {pos}");
