// Задача 21/ Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void findDistance(int x1, int y1, int z1, int x2, int y2, int z2){
 double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
 Console.WriteLine("Расстояние между точкой А с координатами ({0},{1},{2}) и точкой B с координатами ({3},{4},{5}) равно {6}", x1, y1,z1, x2, y2, z2, Math.Round(d, 2));
}
Console.Write("Введите последовательно координаты вида x y z для точки А ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите последовательно координаты вида x y z для точки В ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
findDistance(x1, y1,z1, x2, y2, z2);