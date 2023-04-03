/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
double[] numN = new double[n];
for (int i = 1; i <= n; i++)
{
  numN[i - 1] = Math.Pow(i, 3);
}

for (int i = 0; i < n; i++)
  Console.Write($"{numN[i]} ");