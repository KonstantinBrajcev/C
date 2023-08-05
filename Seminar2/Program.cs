// Seminar2
/*
13254 / 10 = 1325
13254 / 100 = 132
13254 / 1000 = 13
13254 / 10000 = 1

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254

24365 -> 43
*/

// TASK1 Программа которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

/*
int CutNumber(int num);
{
    int hundreds = num / 100;
    int units = num % 10;
    return hundreds * 10 + units;
}
int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New Version of {randNumber} is {newNumber}");
*/

/*
bool IsDivisible(int num, int div1, int div2)
{
    // if (num %div1 == 0 &&)
    return num % div1 == 0 && num % div2 == 0;
}
Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a First DIV1");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a First DIV2");
int div2 = Convert.ToInt32(Console.ReadLine());

bool res = IsDivisible(number, div1, div2);
if (res) Console.Write("YES");
else Console.Write("NO");
*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int number = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + number);
int maxDigit = 0;
int currentDigit = 0;
while (number > 0)
{
    currentDigit = number % 10;
    if (currentDigit > maxDigit)
    {
        maxDigit = currentDigit;
    }
    number /= 10;
}
Console.WriteLine("Наибольшая цифра числа: " + maxDigit);
*/
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1)
{ Console.WriteLine("Одно число является квадратом другого."); }
else
{ Console.WriteLine("Эти числа не являются квадратами друг друга."); }
*/
//
/*
int MaxNum(int num)
{
    int num1 = num % 10;
    int num2 = num / 10;
    if (num1 > num2) return num1;
    else return num2;
}
int number = new Random().Next(10, 100);
Console.WriteLine(number);
int res = MaxNum(number);
Console.WriteLine(res);
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        // int y = Convert.ToInt32(Console.ReadLine());
        Fact(x);
    }

    private static void Fact(int x) //Считаем методом
    {
        // int result = Convert.ToInt32((x * y) + Math.Pow(x, 2));
        int n = 1;
        for (int i = 2; i <= x; i++)
        {
            n *= i;
        }
        Print(n);
        // Print(result);
    }

    private static void Print(int x) //Печатаем методом
    {
        Console.WriteLine("Факториал {0} равен {1}", x, n);
    }
}