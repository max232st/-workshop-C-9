// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write(Sum(m, n));
}

int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Main();