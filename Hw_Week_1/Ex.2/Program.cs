using System;

namespace Ex._2
{
    class Program
    {
        static int Sum(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum; 
        }
        static void Main(string[] args)
        {
            int min = 100000;
            int max = 999999;
            int half1;
            int half2;
            int number_of_ticket;
            Console.WriteLine($"Задание 2");
            Console.WriteLine($"\"Счастливый билет\"");
            Console.Write($"Введите номер билета: ");
            number_of_ticket = Convert.ToInt32(Console.ReadLine());

            if (number_of_ticket < min || number_of_ticket > max)
            {
                Console.WriteLine($"Не корректный номер");
            }

            half1 = number_of_ticket / 1000;
            half2 = number_of_ticket % 1000;

            if (Sum(half1) == Sum(half2)) Console.WriteLine($"У Вас счастливый билет!");
            else Console.WriteLine($"Увы! В следующий раз повезет");
        }
    }
}
