﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = 1;

while(min <= n)
{
    if (min %2 == 0) Console.Write(min + " ");
    min++;
}
