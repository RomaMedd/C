// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        array[i] = Int32.Parse(Console.ReadLine()!);
    }
}

int plus(int[] numbers)
{
    int index = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >0)
        index++;
    }
    Console.Write($"Количество чисел больше 0: {index}");
    
    return index;
}


Console.Write("Введите количество чисел: ");
int[] size = new int[Int32.Parse(Console.ReadLine()!)];
FillArray(size);

int positive = plus(size);

