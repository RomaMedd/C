//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int number;
int index = 1;
int result;
Console.Write("Введите число: ");
number= Int32.Parse(Console.ReadLine());

while (index < number + 1)
{
    result = index * index * index;
    index++;
    Console.Write(result + ", ");

}
