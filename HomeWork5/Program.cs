// 28.08.2023
// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
System.Console.Write("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
MyInsert(m);
void MyInsert(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++) //Вводим числа
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Summa(array);
}
void Summa(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { summ++; }
    }
    Print(array);
    System.Console.WriteLine(summ);
}
void Print(int[] array)
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

// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// (k1 * x) - (c1 * y) + b1 = 0 // (k2 * x) - (c2 * y) + b2 = 0
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
double[] Line1 = InputData(1);//Значения первой прямой
double[] Line2 = InputData(2);//Значения второй прямой
double[] InputData(int number)//Выводим приглашения к вводу данных
{
    double[] Line = new double[2];
    Line[0] = Prompt($"Введите коэффициент K{number} прямой > ");
    Line[1] = Prompt($"Введите константу B{number} прямой > ");
    return Line;
}
double Prompt(string message)// Вводим данные с клавиатуры
{
    System.Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine());
}
if (Validate(Line1, Line2))// Проверяем условия наличия решения
{
    double[] point = FindPoint(Line1, Line2);
    System.Console.WriteLine($"Точка пересечения уравнений y = {Line1[0]}*x + {Line1[1]} и y = {Line2[0]}*x + {Line2[1]} ");
    System.Console.WriteLine($"имеет кординаты : x = {point[0]} y = {point[1]} ");
}
double[] FindPoint(double[] Line1, double[] Line2)//Находим координаты точки пересечения
{
    double[] point = new double[2];
    point[0] = (Line1[1] - Line2[1]) / (Line2[0] - Line1[0]);
    point[1] = (((Line1[1] * Line2[0]) - (Line2[1] * Line1[0])) / (Line2[0] - Line1[0]));
    return point;
}
bool Validate(double[] Line1, double[] Line2)//Проверяем наличие точки пересечения
{
    if (Line1[0] == Line2[0])
    {
        if (Line1[1] == Line1[1])
        {
            System.Console.WriteLine("Прямые совпадают: бесконечное множество точек персечения");
            double[] point = FindPoint(Line1, Line2);
            System.Console.WriteLine($"Точка пересечения уравнений y = {Line1[0]}*x + {Line1[1]} и y = {Line2[0]}*x + {Line2[1]} ");
            System.Console.WriteLine($"имеет кординаты : x = {point[0]} y = {point[1]} ");
            // return false;
        }
        else
        {
            System.Console.WriteLine("Прямые параллельны: точки пересечения отсутствуют");
            double[] point = FindPoint(Line1, Line2);
            System.Console.WriteLine($"Точка пересечения уравнений y = {Line1[0]}*x + {Line1[1]} и y = {Line2[0]}*x + {Line2[1]} ");
            System.Console.WriteLine($"имеет кординаты : x = {point[0]} y = {point[1]} ");
        }
        return false;
    }
    return true;
}
*/

//Boost - написать программу преобразующую число из десятичной системы исчисления в двоичную
/*
Console.Write("Введите число в десятичной системе: ");
int ten_number = Convert.ToInt32(Console.ReadLine());
string two_number = Binar(ten_number);
string Binar(int number)
{
    string two = Convert.ToString(number % 2); // Ложим первое значение (бинарное)
    number /= 2; //отстаток от деления
    while (number > 1)
    {
        two = $"{two}{Convert.ToString(number % 2)}";
        number /= 2; //отстаток от деления            
    }
    two = $"{two}{Convert.ToString(number)}";
    char[] array = two.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}
Console.WriteLine($"В двоичной системе это: {two_number}");
*/
