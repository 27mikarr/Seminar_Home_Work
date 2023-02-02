// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int SumArrayCount = 0;

FillArray(array);
Console.Write("Сгенерированный массив ");
PrintArray(array);
SumArray(array);
Console.WriteLine("\b\b ");
Console.WriteLine($"Сумма элементов нечетных позиций в  сгенерированном массиве равна : {SumArrayCount}");
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10 + 1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
       {
        if(i % 2 != 0)
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
void SumArray(int[] array)
{
 for (int i = 0; i < array.Length; i++)
 {
    if(i % 2 != 0)
    {
        SumArrayCount = SumArrayCount + array[i];
    }
 }   
}