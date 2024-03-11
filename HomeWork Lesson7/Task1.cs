﻿// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.


void Gap(int M, int N)
{
    if (N == M)
    {
        Console.Write("Промежуток из натуральных чисел от M до N составляет: " + N + " ");
        return;
    }     
    Gap(M, N-1);
    Console.Write(N + " "); 
 }

Console.Clear();
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(M < 0)
    {   
        M = M * -1;
    }
    else if (N < 0)
    {
        N = N * -1;
    }
    else if(N < M)
    {
        int num = 0;
        num = N;
        N = M;
        M = num;
    }
Gap(M , N);


