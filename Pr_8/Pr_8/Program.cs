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
        Console.WriteLine("Здравствуйте!"); // приветствие
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nПродолжать программу? Если да - нажмите Y, если нет - нажмите N");
            string select_key = Console.ReadLine();
            switch (select_key)
            {
                case "Y": // кейс Yes
                    {
                        try
                        {

                            Console.WriteLine("\nВы нажали Y - программа продолжает свою работу!\n");
                            int min = int.MaxValue; // присвоение значения переменной к максимальному значению int
                            do // цикл
                            {
                                Console.Write("Введите число: "); 
                                int num = Convert.ToInt32(Console.ReadLine()); // вывод

                                if (num == 0) // если
                                {
                                    Console.WriteLine("\nОстановка программы...\n");
                                    break;
                                }

                                if (num < min)
                                {
                                    min = num;
                                }

                            } while (true);

                            Console.WriteLine("Минимальное число: " + min);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine("Ой... Что-то пошло не так... " + fe.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ой... Что-то пошло не так... " + ex.Message);
                        }
                    }
                    break;
                case "N": // кейс No
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nВы нажали N - программа прекращает свою работу!\n");
                        Console.WriteLine("До свидания!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}