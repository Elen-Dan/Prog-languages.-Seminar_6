﻿/*
Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Рекомендую учесть три возможных случая расположения двух прямых.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/ 
Console.Clear();

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
if (b1 == b2 & k1 == k2)
    Console.WriteLine("Прямые совпадают");
 double x = (b2 - b1) / (k1 - k2);
 double y = k1 * x + b1;

Console.WriteLine("Координаты пересечения двух прямых: " + "x: " + x + " y: " + y);
