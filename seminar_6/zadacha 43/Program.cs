﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void findCoordinates ()
{
    Console.WriteLine("Enter coordinates");
    double k1 = Convert.ToInt32(Console.ReadLine());
    double k2 = Convert.ToInt32(Console.ReadLine());
    double b1 = Convert.ToInt32(Console.ReadLine());
    double b2 = Convert.ToInt32(Console.ReadLine());
    double x = (b1 - b2)/(k2 - k1);
    double y = x * k1 + b1;
    Console.WriteLine("{0} , {1}", x , y);
}

findCoordinates();