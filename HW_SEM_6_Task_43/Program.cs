// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.Write("Для нахождения точек пересечения 2-х прямых: задайте коэффициенты уравнения  y = k1*x+b1, введите значение k1 :");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Теперь, введите значение b1 :");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Теперь задайте коэффициенты второго уравнения  y = k2*x+b2, введите значение k2 :");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Теперь, введите значение b2 :");
int b2 = Convert.ToInt32(Console.ReadLine());


if(k1 == k2)
{
    Console.Write("Заданные прямые не пересекаются");
}