// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


using System;
using static System.Console;
Clear();

WriteLine("Введите минимальное значение ");
int numMin = Convert.ToInt32(ReadLine());
WriteLine("Введите максимальное значение");
int numMax = Convert.ToInt32(ReadLine());
int[] newArr = new int [8];
FillArr(newArr, numMin, numMax);
WriteLine(String.Join(",",FillArr(newArr, numMin, numMax)));
int[] FillArr(int[] array, int minV, int maxV)
{
    int[] filledArr = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        filledArr[i] = new Random().Next(minV,maxV+1);
    }
    return filledArr;

}