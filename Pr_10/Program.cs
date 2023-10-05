//************************************************************************************
//* Практическая работа №6                                                           *
//* Выполнил Коровин К.А., группа 2-ИСП                                              *
//* Задание: составить программу работы алгоритма использованием двумерного массива  *
//************************************************************************************
using System;

namespace Pr_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int m = 5, n = 6;
            double[,] A = new double[m, n];
            Random r = new Random();
            for (int i = 0, j = 0; i < m && j < n; i++, j++)
            {
                A[i, j] = r.NextDouble()*(54.0 - (-98.0)) + (-98.0);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("{0:#.#}", A[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
