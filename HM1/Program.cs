// Урок 4. Функции продолжение
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;
Clear();

WriteLine("Введите первое  число");
int number = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int number1 = Convert.ToInt32(ReadLine());
WriteLine ($"{number} в натуральной степени {number1} = {PowerCalc(number, number1)}");
int PowerCalc(int a, int b)
{
    int answer;
    answer = Convert.ToInt32(Math.Pow(a, b));
    return answer;
}



