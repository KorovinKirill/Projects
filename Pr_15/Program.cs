//************************************************************************************
//* Практическая работа №15                                                          *
//* Выполнил Коровин К.А., группа 2-ИСП                                              *
//* Задание: Структуры                                                               *
//************************************************************************************
using System;
using System.Net;
using System.Threading;

struct Journey
{
    public string startPoint;
    public string endPoint;
    public decimal cost;
    public uint duration;
}

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Практическая работа №15";
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Здравствуйте!"); // приветствие
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nПродолжать программу? Если да - нажмите Y, если нет - нажмите N: ");
            string select_key = Console.ReadLine();
            switch (select_key)
            {
                case "Y":
                    {
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nВведите количество путешествий: ");
                            int n = int.Parse(Console.ReadLine());

                            Journey[] journeys = new Journey[n];


                            for (int i = 0; i < n; i++) // Ввод данных о путешествиях
                            {
                                Console.WriteLine($"\nВведите данные о путешествии {i + 1}: ");
                                Console.Write("Начальный пункт маршрута: ");
                                journeys[i].startPoint = Console.ReadLine();
                                Console.Write("Конечный пункт маршрута: ");
                                journeys[i].endPoint = Console.ReadLine();
                                Console.Write("Стоимость путешествия: ");
                                journeys[i].cost = Decimal.Parse(Console.ReadLine());
                                Console.Write("Продолжительность (Часы): ");
                                journeys[i].duration = Convert.ToUInt32((float)Double.Parse(Console.ReadLine()));
                            }

                            Array.Sort(journeys, (j1, j2) => j1.duration.CompareTo(j2.duration)); // Сортировка путешествий по продолжительности маршрутов

                            Console.Write("Введите название пункта маршрута: ");
                            string targetPoint = Console.ReadLine();

                            bool foundJourney = false; // Использую флажек

                            foreach (var journey in journeys) // Поиск и вывод информации о маршрутах, начинающихся или заканчивающихся в заданном пункте
                            {
                                if (journey.startPoint == targetPoint || journey.endPoint == targetPoint)
                                {
                                    Console.WriteLine($"Маршрут: {journey.startPoint} -> {journey.endPoint}");
                                    Console.WriteLine($"Стоимость: {journey.cost}");
                                    Console.WriteLine($"Продолжительность: {journey.duration} ч");
                                    Console.WriteLine();
                                    foundJourney = true;
                                }
                            }

                            if (!foundJourney)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nНе найдено путешествий, начинающихся или заканчивающихся в заданном пункте.");
                            }

                            decimal maxCost = 0;  // Поиск и вывод информации о наиболее дорогих путешествиях

                            foreach (var journey in journeys) // Определение наибольшей стоимости путешествия
                            {
                                if (journey.cost > maxCost)
                                {
                                    maxCost = journey.cost;
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nИнформация о наиболее дорогих путешествиях:");
                            foreach (var journey in journeys)
                            {
                                if (journey.cost == maxCost)
                                {
                                    Console.WriteLine($"Маршрут: {journey.startPoint} -> {journey.endPoint}");
                                    Console.WriteLine($"Стоимость: {journey.cost}");
                                    Console.WriteLine($"Продолжительность: {journey.duration} ч");
                                }
                            }

                        }
                        catch (FormatException fe)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; 
                            Console.WriteLine("Ой. Формат аргумента недопустим! " + fe.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ой. Что-то пошло не так! " + ex.Message);
                        }
                    }
                    break;
                case "N":
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
