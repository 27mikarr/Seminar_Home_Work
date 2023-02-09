// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Задайте размер массива, введите количество строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте размер массива, введите количество столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
Double[,] array2d = new Double[m, n];

Console.WriteLine();
FillArray(array2d);
PrintArray(array2d);

void FillArray( Double[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            arry[row, col] = Math.Round((new Random().NextDouble() * 20 - 10), 2);
        }
    }
}

void PrintArray( Double[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            Console.Write($" {arry[row, col],3} ");
        }
        Console.WriteLine();
    }
}
