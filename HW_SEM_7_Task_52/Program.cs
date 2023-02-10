// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Задайте размер массива, введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте размер массива, введите количество столбцов : ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[row, col];

Double arithMean = 0;


    Console.WriteLine();
    FillArray(array2d);
    PrintArray(array2d);
    FindArithMean(array2d);

void FillArray( int[,] arry)
{
    for (int row = 0; row < arry.GetLength(0); row++)
    {
        for (int col = 0; col < arry.GetLength(1); col++)
        {
            arry[row, col] = new Random().Next(-10, 11);
        }
    }
}

void PrintArray( int[,] arry)
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

void FindArithMean( int[,] arry)
{
    for (int col = 0; col < arry.GetLength(1); col++)
    {
            arithMean = 0;
        for (int row = 0; row < arry.GetLength(0); row++)
        {
            arithMean = arithMean + array2d[row, col];
        }
        Console.WriteLine($" среднее арифметическое для строки {col +1} равно {arithMean / row} ");
    }
}