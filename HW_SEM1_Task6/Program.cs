﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да  -3 -> нет 7 -> нет

Console.Write("Введите целое число: ");
int number1 = int.Parse(Console.ReadLine());

if ( number1 % 2==1 || number1 % 2==-1 )
{
    Console.WriteLine($" Введенное число : {number1} нечетное ");
}
else
{
Console.WriteLine($" Введенное число : {number1} четное ");
}