// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int CheckNum = 0;
FillArray(array);
Console.Write("Сгенерированный массив в  диапазоне трехзначных положительных чисел (четные числа отмечены *) ");
PrintArray(array);
CheckArray(array);
Console.WriteLine("\b\b ");
Console.WriteLine($"Количество четных чисел в сгенерированном массиве равно : {CheckNum}");
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999 + 1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
        Console.Write(array[i] + "* ");
        }
        else
        {
            Console.Write(array[i] + " ");
        }   
    }
    Console.Write(" ]");
}
void CheckArray(int[] array)
{
 for (int i = 0; i < array.Length; i++)
 {
    if(array[i] % 2 == 0)
    {
        CheckNum = CheckNum +1;
    }
 }   
}