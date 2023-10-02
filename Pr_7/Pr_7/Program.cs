//************************************************************************************
//* Практическая работа №7                                                           *
//* Выполнил Коровин К.А., группа 2-ИСП                                              *
//* Задание: составить программу работы циклического алгоритма с использованием For  *
//************************************************************************************
using System;

namespace Pr_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №7";
            Console.WriteLine("Здравствуйте!"); // приветствие

            while (true)
            {
                Console.WriteLine("\nПродолжить программу? Если да - нажмите Y, если нет - нажмите N");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        Console.WriteLine("\nВы нажали Y, - программа продолжает свою работу!\n");
                        try
                        {

                            double s, count, all = 0; // объявление переменных
                            int i = 1, exit = 0, godS = 0, godKolvo = 0, godVsego = 0;
                            bool uslovie;

                            uslovie = true; // присвоение переменных
                            s = 100; // протяжённость участка в Га
                            count = 20; // средняя урожайность центнеров с Га

                            for (; uslovie; i++) // цикл
                            {
                                s += s * 0.05;

                                if ((s > 120) && (godS == 0)) // если
                                {
                                    exit++;
                                    godS = i;
                                    Console.WriteLine($"площадь превысит 120 (площадь {Math.Round(s, 5)} Га) в {godS} году");
                                }

                                count += count * 0.02;

                                if ((count > 23) && (godKolvo == 0))
                                {
                                    exit++;
                                    godKolvo = i;
                                    Console.WriteLine($"урожайность превысит 23 (собранно {Math.Round(count, 5)} центнеров) в {godKolvo} году");
                                }

                                all += count;

                                if ((all > 850) && (godVsego == 0))
                                {
                                    exit++;
                                    godVsego = i;
                                    Console.WriteLine($"общий урожай с 1 гектара за все года превысит 850 центнеров (собранно {Math.Round(all, 5)} центнеров) в {godVsego} году");
                                }

                                if (exit == 3)
                                {
                                    uslovie = false;
                                }
                            }
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
                        Console.WriteLine("До свидания!");
                        Console.ReadKey();
                        break;
                    case "N":
                        Console.WriteLine("\nВы нажали N - программа прекращает свою работу!\n");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
