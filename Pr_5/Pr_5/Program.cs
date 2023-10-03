//************************************************************
//* Практическая работа №5                                   *
//* Выполнил Коровин К.А., группа 2-ИСП                      *
//* Задание: составить программу работы алгоритма ветвления  *
//************************************************************
using System;

namespace Pr_5
{
    internal class Program
    {
        static void Main(string[] args) // точка входа в программу
        {
            double a, b, c, d, x1, x2; // объявление переменных
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Здравствуйте!"); // приветствие
            Console.Write("Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());

            d = Math.Pow(b, 2) - 4 * a * c; // вычисление дискриминанта 

            if ((b == 0) | (c == 0)) //  если
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Решений нет");
            }

            else if (d < 0) // иначе, если
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Действительных корней нет");
            }

            else // иначе
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }
}