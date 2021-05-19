using System;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            int count=0;
            
            do
            {
                Console.Clear();
                Console.WriteLine($"Задание 1");
                Console.WriteLine($"Программа считывает количество нажатий клавиши пробел");
                Console.WriteLine($"Для выхода из программы нажмите точку\n");
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Spacebar) count++;
                Console.WriteLine($"Пробел нажат {count} раз");
            } while (cki.Key!=ConsoleKey.OemPeriod);
          
        }
    }
}
