//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int number1 = int.Parse(Console.ReadLine());
int check3digit = number1 / 100;
if (check3digit == 0)
 {
    Console.Write(" Введенное число не является 3 -х значным");
 }
 else if (check3digit >= 10)
 {
    Console.WriteLine(" Введенное число имеет большую разрядность");
 }
 else if (check3digit < 1)
 {
    int secondchar = (number1 % 100) / (-10);
    Console.Write($" второй символ числа  : {secondchar} ");
 }
  else
 {
    int secondchar = (number1 % 100) / 10;
    Console.Write($" второй символ числа  : {secondchar} ");
 }