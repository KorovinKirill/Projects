//************************************************************
//* Практическая работа №7                                   *
//* Выполнил Коровин К.А., группа 2-ИСП                      *
//* Задание: составить программу работы линейного алгоритма  *
//************************************************************
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
                
                double s, kolvo, vsego = 0; // объявление переменных
                int i, vixod, godS, godKolvo, godVsego;
                bool uslovie;

                uslovie = true; // присвоение переменных
                s = 100;
                kolvo = 20;
                vixod = 0;
                godS = 0;
                godKolvo = 0;
                godVsego = 0;
                i = 1;

                for (; uslovie; i++) // цикл
                {
                    s = s + s * 0.05;

                    if ((s > 120) && (godS == 0))
                    {
                        vixod++;
                        godS = i;
                    }

                    kolvo = kolvo + kolvo * 0.02;

                    if ((kolvo > 23) && (godKolvo == 0))
                    {
                        vixod++;
                        godKolvo = i;
                    }

                    vsego += kolvo;

                    if ((vsego > 850) && (godVsego == 0))
                    {
                        vixod++;
                        godVsego = i;
                    }

                    if (vixod == 3)
                    {
                        uslovie = false;
                    }
                }
                Console.WriteLine("урожайность превысит 23 в {0} году", godKolvo);
                Console.WriteLine("площадь превысит 120 в {0} году", godS);
                Console.WriteLine("общий урожай с 1 гектара за все года превысит 850 центнеров в {0} году", godVsego);
                Console.ReadKey();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка" + fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка" + ex.Message);
            }


        }
    }
}
