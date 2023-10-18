using System;

namespace Pr_15
{
    internal class Program
    {
        struct Journey
        {
            string start_point;
            string end_point;
            double cost;
            uint time;

            public Journey(string start_point, string end_point, double cost, uint time)
            {
                this.start_point = start_point;
                this.end_point = end_point;
                this.cost = cost;
                this.time = time;
                WriteJourney();
            }

            void WriteJourney()
            {
                Console.WriteLine("Начальный пункт: {0} \nКонечный пункт: {1} \nСтоимость: {2}р \nПродолжительность: {3} месяц", start_point, end_point, cost, time);
            }

            
        }
        static void Main(string[] args)
        {
            Journey journey1 = new Journey("Санкт - Петербург", "Сицилия", 120000, 1);
            Console.ReadKey();
        }
    }
}
