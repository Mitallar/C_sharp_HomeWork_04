﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int num1, int num2)
{
    int result = 1;
    for(int i = 1; i <= num2; i++)
    {
    result = result * num1;
    }
    return result;
}
Console.WriteLine("Введите натуральное число A");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int num2 = Convert.ToInt32(Console.ReadLine());

int degree = Degree(num1, num2);
Console.WriteLine($"Число A в степени B равняется {degree}");