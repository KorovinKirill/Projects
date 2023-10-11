//***************************************************************************
//* Практическая работа №9                                                  *
//* Выполнил Коровин К.А., группа 2-ИСП                                     *
//* Задание: составить программу работы алгоритма с использованием массива  *
//***************************************************************************
using System;

namespace Pr_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №9";
            Console.WriteLine("Здравствуйте!"); // приветствие

            int count = 1;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // объявление массива
            for (int elemm = 0; elemm < array.Length; elemm++)
            {
                for (int elempm = elemm + 1; elempm < array.Length; elempm++)
                {
                    if (array[elemm] == array[elempm])
                        break;
                  
                    if (elempm == array.Length - 1) count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
