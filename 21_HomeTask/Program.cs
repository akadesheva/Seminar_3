﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите данные X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите данные Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите данные Z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите данные X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите данные Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("ВВедите данные Z2: ");
double z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)); // (x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2)

Console.WriteLine($"d={d:f2}"); // :f2 - обозначает что после запятой мы хотим видеть только две цифры
