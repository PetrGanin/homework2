﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
 int i =1;
 Console.Write("Числа от 1 до N возведенные в куб: ");
while (i < N)
{
   Console.WriteLine(Math.Pow(i,3));
   i++;
}