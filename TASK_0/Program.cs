﻿// 0. Демонстрация решения
// Напишите программу, которая 
// 1. на вход принимает число
// 2. выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = 4; // -2.147 млрд до 2.147 млрд
int res = num * num;
Console.WriteLine($"Квадрат числа {num} = {res}");