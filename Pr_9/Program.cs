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
            Random rnd = new Random();
            int i;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nХотите продолжить? Нажмите 1, если да. Нажмите 0, если нет: ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "1":
                        {
                            try
                            {
                                while (true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("\nВведите размерность массива: ");
                                    int dimension = Convert.ToInt32(Console.ReadLine());

                                    int[] array = new int[dimension];
                                    int count = 1;

                                    Console.Write("\nБудите использовать рандом? Нажмите a, если да. Нажмите b, если сами наберете значения массива: ");
                                    string l = Console.ReadLine();
                                    switch (l)
                                    {

                                        case "a": // рандом в массиве
                                            {
                                                Console.ForegroundColor = ConsoleColor.White;
                                                int a, b;
                                                Console.Write("\nНапишите правую границу: ");
                                                a = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("\nНапишите левую границу: ");
                                                b = Convert.ToInt32(Console.ReadLine());
                                                while (a > b || a == b)
                                                {
                                                    for (i = 0; i < dimension; i++)
                                                    {
                                                        array[i] = rnd.Next(b, a);
                                                        Console.Write(array[i] + " ");
                                                    }
                                                    for (int elemm = 0; elemm < array.Length; elemm++)
                                                    {
                                                        for (int elempm = elemm + 1; elempm < array.Length; elempm++)
                                                        {
                                                            if (array[elemm] == array[elempm])
                                                                break;

                                                            if (elempm == array.Length - 1) count++;
                                                        }
                                                        
                                                    }
                                                    Console.WriteLine("\nРазличныхх элементов массива: ", count);

                                                    break;
                                                    
                                                }
                                                if (a < b) Console.WriteLine("Левая граница не может быть больше правой!\n");

                                            }
                                            break;

                                        case "b": // значения с клавиатуры
                                            {
                                                try
                                                {
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    for (i = 0; i < dimension; i++)
                                                    {
                                                        Console.Write("Введите [" + i + "] элемент: ");
                                                        array[i] = Convert.ToInt32(Console.ReadLine());
                                                    }
                                                }

                                                catch (FormatException fe)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Ошибка... Введён неверный формат... " + fe.Message);
                                                }
                                                catch (Exception ex)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Ошибка... " + ex.Message);
                                                }
                                                break;
                                            }
                                        default:
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\nНеизвестный выбор.\n");
                                            break;
                                    }
                                }
                            }
                            catch (FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка... Введён неверный формат... " + fe.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка... " + ex.Message);
                            }
                            break;
                        }

                    case "0":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вы нажали 0 - программа прекращает свою работу!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Хорошего настроения, до свидания!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nНеизвестный выбор.");
                        break;
                }
            }
        }
    }
}
