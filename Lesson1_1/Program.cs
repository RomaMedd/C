﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22



int a = 2;
int b = 3;
int c = 7;
int max = a;

Console.Write("max = ");
Console.WriteLine(Math.Max(Math.Max(a, b), c));