﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 
Console.Clear();
int count = 0;
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число");
int degree = int.Parse(Console.ReadLine()!);
int result = DegNumber(number, degree);
Console.Write(result);

int DegNumber(int number, int degree)

{

    if (count == degree) return 1;
    count++;
    return number * DegNumber(number, degree);
}
