﻿//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

    int n, d1, d3;
    Console.Write("Введите трехзначное число: ");
    n= Int32.Parse(Console.ReadLine());
    d1 = n / 100;
    d3 =  n % 10;
    if (d1 > 0)
    {
        Console.WriteLine("Третья цифра: " + d3);
    }
    else
    Console.WriteLine("Третьей цифры нет!");
   