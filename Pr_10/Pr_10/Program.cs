//************************************************************************************
//* Практическая работа №10                                                          *
//* Выполнил Коровин К.А., группа 2-ИСП                                              *
//* Задание: составить программу работы алгоритма использованием матрицы             *
//************************************************************************************
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Практическая работа №10";
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

                            int m = 5; // число строк
                            int n = 6; // число столбцов

                            int[,] matrix = new int[m, n];

                            Random random = new Random(); // Рандом

                            for (int i = 0; i < m; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    matrix[i, j] = random.Next(-98, 54);
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nИсходная матрица: "); // выводим матрицу на экран
                            for (int i = 0; i < m; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    Console.Write(matrix[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadKey();
                            Console.WriteLine();

                            int[] counts = new int[n]; // массив для хранения количества четных элементов в каждом столбце
                            int[] sums = new int[n]; // массив для хранения суммы четных элементов в каждом столбце

                            for (int j = 0; j < n; j++) // подсчитываем количество четных элементов и сумму по каждому столбцу
                            {
                                for (int i = 0; i < m; i++)
                                {
                                    if (matrix[i, j] % 2 == 0)
                                    {
                                        sums[j] += matrix[i, j];
                                        counts[j]++;
                                    }
                                }
                            }

                            Console.Write("Количество четных элементов в каждом столбце:\n");
                            for (int j = 0; j < n; j++)
                            {
                                if (counts[j] == 0) Console.WriteLine("Столбец {0}: Нет чётных чисел!", j + 1);
                                  else Console.WriteLine("Столбец {0}: {1}", j + 1, counts[j]);
                            }
                            Console.ReadKey();
                            Console.Write("\nСумма четных элементов в каждом столбце:\n");
                            for (int j = 0; j < n; j++) 
                            {
                                if (counts[j] == 0) Console.WriteLine("Столбец {0}: Нет чётных чисел!", j + 1);
                                  else Console.WriteLine("Столбец {0}: {1}", j + 1, sums[j]); 
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
                default:
                    Console.WriteLine("\nНеизвестный выбор.");
                    break;
            }
        }
    }
}
