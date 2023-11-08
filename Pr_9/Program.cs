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
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Практическая работа №9";
            Console.WriteLine("Здравствуйте!"); // приветствие
            Random rnd = new Random();
            int i;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nПродолжать программу? Если да - нажмите Y, если нет - нажмите N: ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        {
                            try
                            {
                                while (true)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("\nВведите размерность массива: ");
                                    int dimension = Convert.ToInt32(Console.ReadLine());

                                    int[] array = new int[dimension];  // инициализация
                                    int count = 1;

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("\nБудите использовать рандом? Нажмите r, если да. Нажмите w, если сами наберете значения массива: ");
                                    string choice = Console.ReadLine();
                                    switch (choice)
                                    {

                                        case "r": // рандом в массиве
                                            {
                                                Console.ForegroundColor = ConsoleColor.White;
                                                int left, right;
                                                Console.Write("\nНапишите левую границу: ");
                                                left = Convert.ToInt32(Console.ReadLine());
                                                Console.Write("\nНапишите правую границу: ");
                                                right = Convert.ToInt32(Console.ReadLine());
                                                Console.ForegroundColor= ConsoleColor.Yellow;
                                                
                                                while (left < right || left == right)
                                                {
                                                    Console.Write("\nМассив: ");
                                                    for (i = 0; i < dimension; i++)  // цикл заполняющий с помощью рандома
                                                    {
                                                        array[i] = rnd.Next(left, right);
                                                        Console.Write(array[i] + " ");
                                                    }
                                                    for (int elemm = 0; elemm < array.Length; elemm++) // цикл вычисляющий различные элементы массива
                                                    {
                                                        for (int elempm = elemm + 1; elempm < array.Length; elempm++)
                                                        {
                                                            if (array[elemm] == array[elempm])
                                                                break;

                                                            if (elempm == array.Length - 1) count++;
                                                        }
                                                    }
                                                    Console.WriteLine("\nРазличных элементов массива: " + count);
                                                    break;
                                                }
                                                if (left > right) Console.Write("Левая граница не может быть больше правой!\n");
                                            }
                                            break;

                                        case "w": // значения с клавиатуры
                                            {
                                                try
                                                {
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    for (i = 0; i < dimension; i++)  // цикл заполняющий с помощью клавиатуры
                                                    {
                                                        Console.Write("Введите [" + i + "] элемент: ");
                                                        array[i] = Convert.ToInt32(Console.ReadLine());
                                                    }
                                                    for (int elemm = 0; elemm < array.Length; elemm++) // цикл вычисляющий различные элементы массива
                                                    {
                                                        for (int elempm = elemm + 1; elempm < array.Length; elempm++)
                                                        {
                                                            if (array[elemm] == array[elempm])
                                                                break;

                                                            if (elempm == array.Length - 1) count++;
                                                        }
                                                    }
                                                    Console.WriteLine("\nРазличных элементов массива: " + count);
                                                    break;
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
                                            }
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\nНеизвестный выбор.\n");
                                            break;
                                    }
                                    break;
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

                    case "N":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\nДо свидания!");
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
