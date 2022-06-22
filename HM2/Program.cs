// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System;
using static System.Console;
Clear();

WriteLine("Введите число");
WriteLine($"Сумма каждого элемента введеного вами числа = {Sum(Convert.ToInt32(ReadLine()))}");
int Sum(int N)
{
 int answer =0;
    while(N>0 )
    {
        answer = answer + N%10;
        N/=10;
    } 
 return answer;
}