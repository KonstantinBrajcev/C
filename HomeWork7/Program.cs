// 04 / 09 / 2023
// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int m = Insert("Введите число строк : ");
int n = Insert("Введите число столбцов : ");
int Insert(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] array = CreatArray(m, n);
int[,] CreatArray(int m, int n)
{
    int[,] array2d = new int[m, n];
    System.Console.WriteLine("Таблица перед сортировкой");
    for (int i = 0; i < m; i++) //Вводим Рандомные числа в массив и считаем четные числа
    {
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(1, 10);
            Console.Write($"[{i}:{j}] - {array2d[i, j]} \t");
        }
        Console.WriteLine();
    }
    Sort(array2d);
    return array2d;
}
void Sort(int[,] array)
{
    Console.WriteLine("Таблица после сортировки");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1)); j++)
        {
            for (int k = 0; k < (array.GetLength(1) - 1); k++)
            {
                if (array[j, k] > array[j, (k + 1)])
                {
                    int temp = array[j, k];
                    array[j, k] = array[j, (k + 1)];
                    array[j, (k + 1)] = temp;
                }
            }
        }
    }
}
Print(array);
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"({i}:{j}) - {array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int m = Insert("Введите длинну строк : ");
int Insert(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] array2d = CreatArrray(m, m);
int[,] CreatArrray(int m, int n)
{
    int[,] array2d = new int[m, n];
    int[] Mass = new int[m];
    for (int i = 0; i < m; i++) //Вводим Рандомные числа в массив и считаем четные числа
    {
        int summa = 0;
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(1, 100);
            Console.Write($"[{i}:{j}] - {array2d[i, j]} \t");
            summa += array2d[i, j];
        }
        Mass[i] = summa;
        Console.WriteLine($"(Сумма строки {summa})");
    }
    int minIndex = Array.IndexOf(Mass, Mass.Min());
    Console.WriteLine($"Строка с наименьшей суммой элементов : {minIndex}");
    return array2d;
}
*/

// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int m = Insert("Введите размер (Ш х В) матриц : ");
int Insert(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("===Первая матрица===");
int[,] matrixOne = CreatArray(m, m);
System.Console.WriteLine("===Вторая матрица===");
int[,] matrixTwo = CreatArray(m, m);
int[,] CreatArray(int m, int n)
{
    int[,] array2d = new int[m, n];
    for (int i = 0; i < m; i++) //Вводим Рандомные числа в массив и считаем четные числа
    {
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(1, 10);
            Console.Write($"[{i}:{j}] - {array2d[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    return array2d;
}
Multiply(matrixOne, matrixTwo);
void Multiply(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixResult[i, j] += (matrix1[i, k] * matrix2[k, j]);
            }
        }
    }
    Print(matrixResult);
}
void Print(int[,] array)
{
    System.Console.WriteLine("===Результирующая матрица===");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"({i}:{j}) - {array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07