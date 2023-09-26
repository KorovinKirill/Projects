//************************************************************
//* Практическая работа №6                                   *
//* Выполнил Коровин К.А., группа 2-ИСП                      *
//* Задание: составить программу работы линейного алгоритма  *
//************************************************************
using System;

namespace Pr_4
{
    internal class Program
    {
        static void Main(string[] args) // точка входа в программу
        {
            double a, b, c, d, x1, x2; //объявление переменных
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());

            d = Math.Pow(b, 2) - 4 * a * c; // вычисление дискриминанта
            switch (d < 0) // проверка условия
            {
                case true:
                    Console.WriteLine("Решений нет");
                    break; 
                case false:
                    switch (d == 0)
                    {
                        case true:
                            {
                                x1 = (-b + Math.Sqrt(d)) / 2 * a; // первый корень
                                Console.WriteLine($"x1 = {x1}");
                                break;
                            }
                        case false:
                            x1 = (-b + Math.Sqrt(d)) / 2 * a;
                            x2 = (-b - Math.Sqrt(d)) / 2 * a; // второй корень
                            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                            break;
                    }
                    break;
            }
            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }
}