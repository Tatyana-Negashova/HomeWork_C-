﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a < N);
{
if  (a % 2 == 0) 
{

Console.Write(a + ",");
}
a += 1;
}
