using System;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задание 4");
            int A ;
            int B ;
            Console.WriteLine($"Введите числа (один из чисел должен быть меньше другого): ");
            Console.Write($"A = "); A = Convert.ToInt32(Console.ReadLine());
            Console.Write($"B = "); B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"");

            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    for (int l = 0; l < i; l++) Console.Write($"{i} ");
                    Console.WriteLine($"");
                }
            }
            else if (A > B)
            {
                for (int i = A; i >= B; i--)
                {
                    for (int l = 0; l < i; l++) Console.Write($"{i} ");
                    Console.WriteLine($"");
                }
            }
            else Console.WriteLine($"Читайте условие ");
            
        }
    }
}
