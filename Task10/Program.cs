﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число:");
string text = Console.ReadLine();
int number = int.Parse(text);

int secondDigit = (number/10)%10;

Console.WriteLine($"Вторая цифра: {secondDigit}");