// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Укажите количество вводимых чисел: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int PosiNum = 0;

EnterArray(array);
PrintArray(array);
void EnterArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число № {i + 1}  из {N}: ");
array[i] = Convert.ToInt32(Console.ReadLine());
     if((array[i]) > 0)
        {
            PosiNum = PosiNum + 1;
        }
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write($" ]  количество чисел больше 0 введенное пользователем равно {PosiNum}");
}
