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
            Random r = new Random();
            const int m = 5, n = 6;
            double[,] A = new double[m, n];
            for (int i = 0, j = 0; i < m && j < n; i++, j++)
            {
                A[i,j] = r.NextDouble();
            }

            for (int i = 0, j = 0;  j < A.GetUpperBound(0); i++, j++)
            {

            }

            Console.ReadKey();

        }
    }
}
