// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
int m = Insert("Введите число строк : ");
int n = Insert("Введите число столбцов : ");
int Insert(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double[,] CreatArrray(int m, int n)
{
    double[,] array2d = new double[m, n];
    for (int i = 0; i < m; i++) //Вводим Рандомные числа в массив и считаем четные числа
    {
        for (int j = 0; j < n; j++)
        {
            int minValue = -99;
            int maxValue = 99;
            double doubleValue = new Random().NextDouble();
            array2d[i, j] = Math.Round(minValue + (doubleValue) * (maxValue - minValue), 1);
        }
    }
    return array2d;
}
PrintArr(CreatArrray(m, n));
void PrintArr(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        System.Console.Write("(");
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (j < (array2d.GetLength(1) - 1))
                System.Console.Write($"{array2d[i, j]}, ");
            else
                System.Console.Write($"{array2d[i, j]}");

        }
        System.Console.WriteLine(")");
    }
}
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int Insert(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] array2d = CreatArrray(Insert("Введите число строк : "), Insert("Введите число столбцов : "));
int[,] CreatArrray(int m, int n)
{
    int[,] array2d = new int[m, n];
    for (int i = 0; i < m; i++) //Вводим Рандомные числа в массив и считаем четные числа
    {
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(1, 10);
            System.Console.Write($"[{i}:{j}] - {array2d[i, j]} ");
        }
        System.Console.WriteLine();
    }
    Zapros(array2d);
    return array2d;
}
void Zapros(int[,] array2d)
{
    int m = Insert("Из какой строки вывести элемент : ");
    int n = Insert("Из какой столбца вывести элемент : ");
    if (((m + 1) > array2d.GetLength(0)) || ((n + 1) > array2d.GetLength(1)))
    {
        if (ZaprosNew(true) == true)
        { Zapros(array2d); }
    }
    else
    {
        Vyvod(array2d, m, n);
        if (ZaprosNew(false) == true)
        { Zapros(array2d); }
    }
}
bool ZaprosNew(bool f)
{
    if (f == true)
    { Console.WriteLine("Такого элемента не существует !"); }
    Console.WriteLine("Будете вводить другой номер элемента? (Y, N) : ");
    string str = Console.ReadLine();
    if (str == "Y")
    { return true; }
    else if (str == "N")
    {
        Console.WriteLine("Нет, так нет !");
        return false;
    }
    else
    { Console.WriteLine("Введено не верное значение!"); }
}
void Vyvod(int[,] array2d, int m, int n)
{ Console.WriteLine($"Элемент ({m}:{n}) -> {array2d[m, n]}"); }
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int m = Insert("Введите число строк : ");
int n = Insert("Введите число столбцов : ");
int Insert(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] array2d = CreatArrray(m, n);
int[,] CreatArrray(int m, int n)
{
    int[,] array2d = new int[m, n];
    float[] sredMass = new float[m];
    for (int i = 0; i < m; i++) //Вводим Рандомные числа в массив и считаем четные числа
    {
        float srednee = 0;
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = new Random().Next(1, 10);
            Console.Write($"[{i}:{j}] - {array2d[i, j]} ");
            srednee += array2d[i, j];
        }
        sredMass[i] = srednee / n;
        Console.WriteLine();
    }
    PrintArray(sredMass, m);
    return array2d;
}
void PrintArray(float[] sredMass, int m)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Среднее значение {i} строки -> {sredMass[i]}");
    }
}
*/