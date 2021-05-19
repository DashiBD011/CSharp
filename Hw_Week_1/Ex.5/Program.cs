using System;

namespace Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задание 5");
            int N;
            int A = 0;
            Console.Write($"Введите целое число: ");
            N = Convert.ToInt32(Console.ReadLine());

            while(N!=0)
            {
                A *= 10;
                A += N % 10;
                N /= 10;
            }
            Console.WriteLine($"Перевертыш: {A}");
        }
    }
}
