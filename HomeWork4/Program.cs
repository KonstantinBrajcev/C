// 10.08.2023
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];
// int summ = 0;
// for (int i = 0; i < array.Length; i++) //Вводим Рандомные числа в массив и считаем четные числа
// {
//     array[i] = new Random().Next(0, 999);
//     if (array[i] % 2 == 0) { summ++; }
// }
// PrintArr(array, summ);  //Выводим массив в строку

// void PrintArr(int[] array, int summ)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < m; i++)
//     {
//         if (i == (m - 1))
//             System.Console.Write($"{array[i]}");
//         else
//             System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write("] -> " + summ);
// }
*/

// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
// int m = Convert.ToInt32(Console.ReadLine());
// MyRandMass(m);
// void MyRandMass(int m)
// {
//     int[] array = new int[m];
//     for (int i = 0; i < array.Length; i++) //Вводим Рандомные числа в массив
//     {
//         array[i] = new Random().Next(0, 999);
//     }
//     SummaElem(array);
// }
// void SummaElem(int[] array)
// {
//     int summa = array[1];
//     for (int i = 3; i < array.Length;)
//     {
//         summa += array[i];
//         i += 2;
//     }
//     PrintArr(array, summa);  //Выводим массив в строку
// }
// void PrintArr(int[] array, int summa)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < m; i++)
//     {
//         if (i == (m - 1))
//             System.Console.Write($"{array[i]}");
//         else
//             System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write("] -> " + summa);
// }
*/

// Задача 38: 
// Задайте массив вещественных чисел
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
/*
System.Console.Write("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
MyRandMass(m);
void MyRandMass(int m)
{
    double[] array = new double[m];
    for (int i = 0; i < array.Length; i++) //Вводим Рандомные числа в массив
    {
        double randomNumber = Math.Round(new Random().NextDouble() * (999 - 0) + 0, 2);
        array[i] = randomNumber;
    }
    MinMas(array);
}
void MinMas(double[] array)
{
    double max = array.Max();
    double min = array.Min();
    Print(array);
    System.Console.Write(max + " - " + min + " = " + (max - min));
}
void Print(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length - 1))
            System.Console.Write($"{array[i]}");
        else
            System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write("] -> ");
}
*/