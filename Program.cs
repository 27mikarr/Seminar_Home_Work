// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите натуральное число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа ");
int degree = Convert.ToInt32(Console.ReadLine());
int pow = num;
for(int i = 2; i <= degree; i++)
{
   pow = pow * num;
   Console.WriteLine($"число {num} в степени {i} равно {pow} ");
}
Console.WriteLine("\b\b ");
