// Задача 29: Напишите программу, которая задаёт массив из N элементов в заданном пользователем диапазоне и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Console.Write("Далее введите нижнюю границу (включительно) численного диапазона заполнения массива: ");
int lownum = Convert.ToInt32(Console.ReadLine());
Console.Write("Далее введите верхнюю границу (включительно) численного диапазона заполнения массива: ");
int hinum = Convert.ToInt32(Console.ReadLine());

FillArray(array);
Console.Write("Массив вот такой получился ");
PrintArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(lownum, hinum + 1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ,");
    }
    Console.Write(" ]");
}