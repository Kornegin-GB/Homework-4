// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using static System.Console;
Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine($"Сумма чисел в числе = {SummNamber(number)}");

int SummNamber(int A)
{
   int result = 0;
   for (int i = 0; i < A; i *= 10)
   {
      int num = A % 10;
      result += num;
      A /= 10;
   }
   return result;
}