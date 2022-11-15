// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void Main()
{
    Console.WriteLine("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    WriteNumbers(n);
}

void WriteNumbers(int n)
{
    if (n % 2 != 0) n -= 1;
    if (n > 1)
    {
        Console.Write(n + " ");
        WriteNumbers(n - 2);
    }
}

Main();

// Console.WriteLine("Введите число ");
// int n = int.Parse(Console.ReadLine());

// for (int i = n; i >= 1; i--)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write(i + " ");
//     }
// }