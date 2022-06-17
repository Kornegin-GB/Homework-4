// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;

Clear();

Write("Введите число А: ");
int numberA = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int numberB = Convert.ToInt32(ReadLine());

WriteLine(Exponentiation(numberA, numberB));

int Exponentiation(int A, int B)
{
   int result = 1;
   for (int i = 1; i <= B; i++)
   {
      result *= A;
   }
   return result;
}