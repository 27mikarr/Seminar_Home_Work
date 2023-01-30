// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное положительное число ");
int num = Convert.ToInt32(Console.ReadLine());
int decrease = 0;
int count = 0;
if (num >= 0)
{
    while (num > 0)
    {
        decrease = num %10;
        num = num / 10;
        count = count + decrease;
        }
Console.WriteLine($" Cумма цифр введенного числа   равна {count} ");
}
else
{
Console.WriteLine("введено отрицательное число");
}
