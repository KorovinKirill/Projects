using System;

class Program
{
    static bool CheckBracketBalance(string text)
    {
        int count = 0;

        foreach (char c in text)
        {
            if (c == '(')
            {
                count++;
            }
            else if (c == ')')
            {
                count--;
                if (count < 0)
                {
                    return false; // Найдена закрывающаяся скобка без предшествующей открывающейся
                }
            }
        }

        return count == 0; // Если значение count равно 0, значит в тексте число открывающихся и закрывающихся скобок совпадает
    }

    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        if (CheckBracketBalance(text))
        {
            Console.WriteLine("Баланс скобок соблюден.");
        }
        else
        {
            Console.WriteLine("Баланс скобок не соблюден.");
        }
        Console.ReadKey();
    }
}