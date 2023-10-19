//*****************************************************************************************************
//* Практическая работа №12                                                                           *
//* Выполнил Коровин К.А., группа 2-ИСП                                                               *
//* Задание: составление методов собственной функции                                                  *
//*****************************************************************************************************
using System;

namespace Pr_12
{
    internal class Program
    {
        static bool CheckBracketBalance(string text) // подпрограмма
        {
            int count = 0;

            foreach (char c in text)
            {
                if (c == '(')
                {
                    count++;
                }
                else if (c == ')')
                {
                    count--;
                    if (count < 0)
                    {
                        return false; // Найдена закрывающаяся скобка без открывающейся
                    }
                }
            }

            return count == 0; // count равно 0 - число открывающихся и закрывающихся скобок совпадает
        }
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №12";
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
                                Console.Write("Введите текст:");
                                string text = Console.ReadLine();

                                if (CheckBracketBalance(text))
                                {
                                    Console.WriteLine("Баланс скобок соблюден.");
                                }
                                else
                                {
                                    Console.WriteLine("Баланс скобок не соблюден.");
                                }

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
}
