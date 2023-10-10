//************************************************************************************
//* Практическая работа №11                                                          *
//* Выполнил Коровин К.А., группа 2-ИСП                                              *
//* Задание: составить программу работы символов и строк                             *
//************************************************************************************
using System;

namespace Pr_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Практическая работа №11";
            Console.WriteLine("Здравствуйте!"); // приветствие

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nВыберите действие: Y - начать работу программы; N - закрыть программу. ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            int countA = 0; // инициализация переменных
                            int countO = 0;
                            string text; // объявление переменной
                            Console.Write("\nВведите, пожалуйста, текст: ");
                            text = Console.ReadLine();

                            if (string.IsNullOrEmpty(text)) // проверка строки на пустоту
                            {
                                Console.WriteLine("\nСтрока пустая! Вы ничего не ввели...\n\nДо свидания!");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }

                            foreach (char c in text) // Перебор всех элементов в строке s1
                            {
                                if (c == 'a' | c == 'A' | c == 'а' | c == 'А') countA++; // если

                                else if (c == 'o' | c == 'O' | c == 'о' | c == 'О') countO++; // иначе, если
                            }

                            Console.WriteLine($"Число символов 'a' и 'A': {countA}");
                            Console.WriteLine($"Число символов 'o' и 'O': {countO}");
                        }
                        catch (FormatException fe)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ой... Что-то пошло не так... {fe.Message}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ой... Что-то пошло не так... {ex.Message}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case "N":
                        Console.WriteLine("\nДо свидания!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nНеизвестный выбор.");
                        break;
                }
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nВыберите действие: Y - продолжить работу программы; N - закрыть программу. ");
                    string select_key2 = Console.ReadLine();
                    switch (select_key2)
                    {
                        case "Y":
                            try
                            {
                                int countA = 0; // инициализация переменных
                                int countO = 0;
                                string text; // объявление переменной
                                Console.Write("\nВведите, пожалуйста, текст: ");
                                text = Console.ReadLine();

                                if (string.IsNullOrEmpty(text)) // проверка строки на пустоту
                                {
                                    Console.WriteLine("\nСтрока пустая! Вы ничего не ввели...\n\nДо свидания!");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                }

                                foreach (char c in text) // Перебор всех элементов в строке s1
                                {
                                    if (c == 'a' | c == 'A' | c == 'а' | c == 'А') countA++; // если

                                    else if (c == 'o' | c == 'O' | c == 'о' | c == 'О') countO++; // иначе, если
                                }

                                Console.WriteLine($"Число символов 'a' и 'A': {countA}");
                                Console.WriteLine($"Число символов 'o' и 'O': {countO}");

                            }
                            catch (FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Ой... Что-то пошло не так... {fe.Message}");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Ой... Что-то пошло не так... {ex.Message}");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case "N":
                            Console.WriteLine("\nДо свидания!");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\nНеизвестный выбор.");
                            break;
                    }
                }
            }
        }
    }
}
