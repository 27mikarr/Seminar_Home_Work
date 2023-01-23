//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int check3digit = number1 / 100;
if (check3digit == 0)
 {
    Console.Write(" Третьей цифры нет");
 }
 else if (number1 < 0)
 {
    string numchar3 = Convert.ToString(number1);
    Console.WriteLine(" третий символ числа :{0} ", numchar3[3]);
 }
  else
 {
    string numchar3 = Convert.ToString(number1);
    Console.WriteLine(" третий символ числа :{0} ", numchar3[2]);
 }