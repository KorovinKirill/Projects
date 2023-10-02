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
            try
            {

                Console.WriteLine("Здравствуйте!"); // приветствие

                double s, count, all = 0; // объявление переменных
                int i, vixod, godS, godKolvo, godVsego;
                bool uslovie;

                uslovie = true; // присвоение переменных
                s = 100; // протяжённость участка в Га
                count = 20; // средняя урожайность центнеров с Га
                vixod = 0;
                godS = 0;
                godKolvo = 0;
                godVsego = 0;
                i = 1;

                for (; uslovie; i++) // цикл
                {
                    s += s * 0.05;

                    if ((s > 120) && (godS == 0)) // если
                    {
                        vixod++;
                        godS = i;
                    }

                    count += count * 0.02;

                    if ((count > 23) && (godKolvo == 0))
                    {
                        vixod++;
                        godKolvo = i;
                    } 

                    all += count;

                    if ((all > 850) && (godVsego == 0))
                    {
                        vixod++;
                        godVsego = i;
                    }

                    if (vixod == 3)
                    {
                        uslovie = false;
                    }
                }
                Console.WriteLine("урожайность превысит 23 (собранно {1} центнеров) в {0} году", godKolvo, count);
                Console.WriteLine("площадь превысит 120 (площадь {1} Га) в {0} году", godS, s);
                Console.WriteLine("общий урожай с 1 гектара за все года превысит 850 центнеров (собранно {1} центнеров) в {0} году", godVsego, all);

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка" + fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка" + ex.Message);
            }
            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }
}
