﻿// Задача 64: Задайте значение N. 
// Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
int n = Insert("Введите число N = ");
int Insert(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
Console.Write('"');
Console.Write(Convert.ToString(Recursion(n)) + '"');
int Recursion(int number)
{
    if (number > 1)
    {
        Console.Write($"{number}, ");
        return Recursion(number - 1);
    }
    else
    {
        return number;
    }
}
*/


// Задача 66: Задайте значения M и N. 
// Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30
/*
int m = Insert("Введите начальное число = ");
int n = Insert("Введите конечное число = ");
Console.WriteLine(Summa(m, n));
int Insert(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Summa(int m, int n)
{
    if (m < n)
    {
        int summ = m;
        for (int i = (m + 1); i <= n; i++)
        {
            summ += i;
        }
        return summ;
    }
    else
    {
        int summ = m;
        for (int i = (m - 1); i >= n; i--)
        {
            summ += i;
        }
        return summ;
    }
}
*/


// Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
/*
int m = Insert("Введите число M = ");
int n = Insert("Введите число N = ");
int Insert(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
Console.WriteLine(Akkerman(m, n));
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return m = Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
*/