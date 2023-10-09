using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Практическая работа №11";
            Console.WriteLine("Здравствуйте!");

            while (true)
            {
                Console.Write("\nПродолжить программу? Если да - нажмите Y, если нет - нажмите N: ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        Console.WriteLine("\nВы нажали Y, - программа продолжает свою работу!\n");
                        try
                        {
                            string s1;
                            Console.Write("Введите, пожалуйста, текст: ");
                            s1 = Console.ReadLine();

                            int countA = 0;
                            int countO = 0;

                            if (string.IsNullOrEmpty(s1))
                            {
                                Console.WriteLine("Строка пустая! Вы ничего не ввели...");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }

                            foreach (char c in s1) // Перебор всех элементов в строке s1 
                            {
                                if (c == 'a' | c == 'A' | c == 'а' | c == 'А')
                                {
                                    countA++;
                                }
                                else if (c == 'o' |  c == 'O' | c == 'о' | c == 'О')
                                {
                                    countO++;
                                }
                            }

                            Console.WriteLine($"Число символов 'a' и 'A': {countA}");
                            Console.WriteLine($"Число символов 'o' и 'O': {countO}");

                        }

                        catch (FormatException fe)
                        {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка" + fe.Message);
                }
                        catch (Exception ex)
                        {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка" + ex.Message);
                }
                
                break;
                    case "N":
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
