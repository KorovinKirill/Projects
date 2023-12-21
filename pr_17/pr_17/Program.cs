//************************************************************************
//* Практическая работа №17                                              *
//* Выполнил: Коровин К.А., группа 2-ИСП                                 *
//* Задание: разработка класса: объявление, создание экземпляров класса. *
//************************************************************************
using System;
using System.Runtime.CompilerServices;

namespace pr17_leskiv
{
    internal class Program
    {
        public static void Error(string message, ConsoleColor cc) // для выявления ошибок
        {
            Console.ForegroundColor = cc;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        class Flying_vehicle
        {
            public string FlyingVehicleName;
            public double speed;

            // Метод для ввода с клавиатуры
            public void InputFromKeyboard()
            {
                do
                {
                    Console.Write("Введите название летающего транспортного средства: ");
                    FlyingVehicleName = Console.ReadLine();
                    if (string.IsNullOrEmpty(FlyingVehicleName))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Летающее транспортное средство не может быть без названия! Пожалуйста, введите название ещё раз.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (string.IsNullOrEmpty(FlyingVehicleName));

                do
                {
                    Console.Write("Введите скорость летающего транспортного средства (км/ч): ");
                    speed = Convert.ToDouble(Console.ReadLine());
                    if (speed < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Скорость летающего транспортного средства не может быть меньше нуля! Пожалуйста, введите скорость ещё раз.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (speed == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Скорость летающего транспортного средства не может быть равна нулю! Пожалуйста, введите скорость ещё раз.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (speed < 0 || speed == 0);

                Console.WriteLine();
            }
            // Метод для вывода на экран
            public void DisplayOnScreen()
            {
                try
                {
                    Console.WriteLine($"Название летающего транспортного средства: {FlyingVehicleName}");
                    Console.WriteLine($"Скорость летающего транспортного средства: {speed}");
                }
                catch (Exception ex)
                {
                    Error(ex.Message, ConsoleColor.Red);
                }
            }
            // Пользовательский метод
            public void UserMethod()
            {
                try
                {
                    double distance, flightTime;
                    Console.Write("Введите время полёта: ");
                    flightTime = Convert.ToDouble(Console.ReadLine());
                    distance = flightTime * speed;
                    Console.WriteLine($"Расстояние, которое пролетел {FlyingVehicleName} за {flightTime} час(-ов): {distance} км.");

                }
                catch (Exception ex)
                {
                    Error(ex.Message, ConsoleColor.Red);
                }
            }
            public Flying_vehicle(string FlyingVehicleName_user, double speed_user)
            {
                this.FlyingVehicleName = FlyingVehicleName_user;
                this.speed = speed_user;
                InputFromKeyboard();
                DisplayOnScreen();
                UserMethod();
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №17";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Здравствуйте!");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nВыберите действие: Y - начать работу программы; N - предварительное закрытие. ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nВы выбрали Y - программа начинает свою работу!\n");
                            string FlyingVehicleName = "";
                            double speed = 0;
                            Flying_vehicle flyingVehicle = new Flying_vehicle(FlyingVehicleName, speed);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException fe)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ой, что-то пошло не так.. {fe.Message}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ой, что-то пошло не так.. {ex.Message}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case "N":
                        Console.WriteLine("\nВы выбрали N - программа заканчивает свою работу!\n");
                        Console.WriteLine("До свидания!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nНеизвестный выбор.");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}