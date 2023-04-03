/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
Console.Write("Введите координату Х точки А: ");
int xa = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int ya = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int za = int.Parse(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
int xb = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yb = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int zb = int.Parse(Console.ReadLine());

  double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
  Console.WriteLine($"Расстояние между точками равно: {result:f2}");

