//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double x1, x2, y1, y2, z1, z2;
Console.Write("Введите координату x1: ");
x1= Int32.Parse(Console.ReadLine());
Console.Write("Введите координату y1: ");
y1= Int32.Parse(Console.ReadLine());
Console.Write("Введите координату z1: ");
z1= Int32.Parse(Console.ReadLine());

Console.Write("Введите координату x2: ");
x2= Int32.Parse(Console.ReadLine());
Console.Write("Введите координату y2: ");
y2= Int32.Parse(Console.ReadLine());
Console.Write("Введите координату z2: ");
z2= Int32.Parse(Console.ReadLine());

// int i = Convert.ToInt32(Math.Sqrt(5.25));

double n = ((x1 - x2) * (x1 - x2)) +
           ((y1 - y2) * (y1 - y2)) +
           ((z1 - z2) * (z1 - z2));

double distance = Math.Sqrt(n);
Console.Write(distance);