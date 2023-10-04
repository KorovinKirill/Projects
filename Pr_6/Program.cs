//************************************************************
//* Практическая работа №6                                   *
//* Выполнил Коровин К.А., группа 2-ИСП                      *
//* Задание: составить программу работы линейного алгоритма  *
//************************************************************
using System;

namespace Pr_6
{
    internal class Program
    {
        static void Main(string[] args) // точка входа в программу
        {
            double a, b, c, d, x1, x2; //объявление переменных
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Здравствуйте!");
            try
            {
                Console.Write("Введите a = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c = ");
                c = Convert.ToDouble(Console.ReadLine());


                d = Math.Pow(b, 2) - 4 * a * c; // вычисление дискриминанта
                switch ((b == 0) | (c == 0)) // проверка условия
                {
                    case true:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Не соответствует условию задачи");
                        break;
                    case false:
                        switch (d < 0)
                        {
                            case true:
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Действительных корней нет");
                                    break;
                                }
                            case false:
                                x1 = (-b + Math.Sqrt(d)) / 2 * a; // первый корень
                                x2 = (-b - Math.Sqrt(d)) / 2 * a; // второй корень
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"x1 = {Math.Round(x1, 2)}, x2 = {Math.Round(x2, 2)}");
                                break;
                        }
                        break;
                }
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка. Формат объекта недопустим. " + fe.Message);
            }
            catch (DivideByZeroException dbze) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Деление на ноль. Ошибка: " + dbze.Message);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что-то пошло не так. Ошибка: " + ex.Message);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("До свидания!");
            Console.ReadKey();
        }
    }
}