// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int ArrMin = 0;
int ArrMax = 0;

FillArray(array);
Console.Write("Сгенерированный массив ");
PrintArray(array);
DiffMax(array);
DiffMin(array);
Console.WriteLine("\b\b ");
Console.WriteLine($"Разница максимального элемента {ArrMax} и минимального элемента {ArrMin} в  сгенерированном массиве равна : {Math.Abs(ArrMax)-Math.Abs(ArrMin)}");
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 99 + 1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" ]");
}
void DiffMax(int[] array)
{
    ArrMax = array[0];
 for (int i = 1; i < array.Length; i++)
{
    if(array[i] > ArrMax)
    {
        ArrMax = array[i];
    }
}}
void DiffMin(int[] array)
{
    ArrMin = array[0];
 for (int i = 1; i < array.Length; i++)
{
    if(array[i] < ArrMin)
    {
        ArrMin = array[i];
    }
}}























// Console.Write("Задайте размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// double[] arrayDouble = new double[N];
// double minArr = 0;
// double maxArr = 0;

// FillArray(arrayDouble);
// Console.Write("Сгенерированный массив ");
// PrintArray(arrayDouble);
// Console.WriteLine("\b\b ");

// void FillArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         arrayDouble[i] = new Random() NextDouble();
//     }
// }

// void PrintArray(double[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//        {
//         if(i % 2 != 0)
//         {
//         Console.Write(array[i] + "* ");
//         }
//         else
//         {
//             Console.Write(array[i] + " ");
//         }   
//     }
//     Console.Write(" ]");
// }