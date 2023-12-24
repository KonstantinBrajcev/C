using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 26);
            int kol = 4;
            //Реализация скрытия курсора
            Console.CursorVisible = false;
            Console.Title = "ЗМЕЙКА";
            const int STD_INPUT_HANDLE = -10;
            IntPtr consoleHandle = GetStdHandle(STD_INPUT_HANDLE);
            SetConsoleMode(consoleHandle, 128);
            //Запрещаем изменять размеры
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            Console.SetCursorPosition(4, 25);
            Console.Write(" СКОРОСТЬ - " + (kol-3) + "\t ДЛИНА - " + kol + "\t ЖИЗНИ - ♥ ♥ ♥");
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек			
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            int speed = 300;

            FoodCreator foodCreator = new FoodCreator(80, 25, '+');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    speed -= 1;
                    kol += 1;
                    Console.SetCursorPosition(4, 25);
                    Console.Write(" СКОРОСТЬ - " + (kol-3) + "\t ДЛИНА - " + kol + "\t ЖИЗНИ - ");
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();
        }


        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("   G A M E     O V E R  ", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("Автор: Константин Брайцев", xOffset + 2, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        //Убираем курсор
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);
    }
}
