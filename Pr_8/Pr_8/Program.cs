//*****************************************************************************************************
//* Практическая работа №8                                                                            *
//* Выполнил Коровин К.А., группа 2-ИСП                                                               *
//* Задание: составить программу работы алгоритма с использованием итерационных циклических структур  *
//*****************************************************************************************************
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Практическая работа №8";
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Здравствуйте!"); // приветствие
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nПродолжать программу? Если да - нажмите Y, если нет - нажмите N: ");
            string select_key = Console.ReadLine();
            switch (select_key)
            {
                case "Y": // кейс Yes
                    {
                        try
                        {

                            
                            double min = double.MaxValue; // импликация переменной к максимальному значению double
                            do // цикл
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Введите число: ");
                                double num = Convert.ToDouble(Console.ReadLine()); // вывод

                                if (num == 0) // если
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("\nОстановка программы...\n");
                                    break; // досрочный выход из программы
                                }

                                if (num < min) min = num;
                              

                            } while (true);

                            Console.WriteLine("Минимальное число: " + min);
                        }
                        catch (FormatException fe)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ой... Формат аргумента недопустим... " + fe.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ой... Что-то пошло не так... " + ex.Message);
                        }
                    }
                    break;
                case "N": // кейс No
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("До свидания!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}