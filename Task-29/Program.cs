// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;
Clear();

int[] mass = new int[8];

FillAray(mass);
PrintArray(mass);

void FillAray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(1, 100);
   }
}

void PrintArray(int[] array)
{
   int i = 0;
   Write("[");
   while (i < array.Length - 1)
   {
      Write($"{array[i]}, ");
      i++;
   }
   WriteLine($"{array.Length - 1}]");
}