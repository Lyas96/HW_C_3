/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.Clear();
Console.Write("Введите пятизначное число ");
int n = int.Parse(Console.ReadLine());
int[] num = new int[5];
int N = n;
int elem = num.Length;
for (int i = (elem - 1); i >= 0; i--)
{
  N = n % 10;
  num[i] = N;
  n = n / 10;
}
if (num[0] != num[elem - 1])
{
  Console.Write("No");
}
else if (num[1] != num[elem - 2])
{
  Console.Write("No");
}
else
{
  Console.Write("Yes!");
}

