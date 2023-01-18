//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4  8 -> 2, 4, 6, 8

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите положительное целое  число: ");
        int number1 = int.Parse(Console.ReadLine());
        int count = 2;

        if (number1 < 0)
        {
            Console.WriteLine(" Введенное число отрицательное ");
        }
        else if (number1 < 2)
        {
            Console.WriteLine(" Введенное число меньше 2  ");
        }
        else
        {
            while (count < number1)
            {
                Console.Write("  ");
                Console.Write(count);
                Console.Write("  ");
                count = count+2;
            }
        }
    }
}