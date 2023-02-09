// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

Console.Write("Задайте размер массива, введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте размер массива, введите количество столбцов : ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[row, col];

Console.Write("Для поиска ячейки массива, введите номер строки : ");
int rowFind = Convert.ToInt32(Console.ReadLine());
Console.Write(" Для поиска ячейки массива, введите номер столбца : ");
int colFind = Convert.ToInt32(Console.ReadLine());


if(colFind > col || rowFind > row)
{
    Console.WriteLine();
    Console.WriteLine(" Искомая позиция не соответствует размерности заданного массива");
}
else
{
    Console.WriteLine();
    FillArray(array2d);
    PrintArray(array2d);
    FindArray(array2d);
}

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

void FindArray( int[,] arry)
{
    Console.Write($" в искомой ячейке (координаты [ {rowFind - 1}:{colFind -1} ] )  следующее число : {arry[rowFind - 1, colFind - 1],3} "); // данные преобразования сделаны так как не указано понимает ли пользователь что отсчет идет от нуля
}