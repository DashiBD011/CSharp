using System;
using System.Globalization;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 4;
            //var number2 = 6;
            //double money = 0.2;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine($"{number}+{number2}={number + number2}");
            //Console.ResetColor();
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine($"Количество денег = {money}");
            //int number;
            //Console.Write("Введите целое число: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //var provider = new NumberFormatInfo();
            //provider.NumberDecimalSeparator = ".";
            //Console.Write("Введите дробное число(через запятую): ");
            //var money = Convert.ToDouble(Console.ReadLine(),provider);
            //Console.WriteLine($"number = {number}");
            //Console.WriteLine($"money = {money}");
            
            //var random = new Random();
            //var arr = new double [10];
            //for(int i = 0; i < 10; i++)
            //{
            //    arr[i] = (double)random.Next(10, 100)/10;
            //}

            //foreach(var element in arr)
            //{
            //    Console.WriteLine($"arr[i] = {element}");

            //}Console.WriteLine();

            //var brr = new int[10];
            //for(int i = 0; i < 10; i++)
            //{
            //   foreach(var element in arr)
            //   {
            //        brr[i] = (int)arr[i];
            //   }
            //}

            //foreach (var element in brr)
            //{
            //    Console.WriteLine($"brr[i] = {element}");

            //}Console.WriteLine();
            var rand = new Random();
            int n = 5;
            var A = new double[n];
            int col = 4;
            int row = 3;
            var B = new double[row, col];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент массива А: ");
                A[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Вывод одномерного массива: ");
            foreach (var element in A)
            {
                Console.Write($"{element}\t");

            }Console.WriteLine();
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    B[i, j] = (double)rand.Next(10, 100)/10;
                }
            }
            Console.WriteLine($"Вывод двумерного массива: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{B[i, j]}\t");

                }Console.WriteLine();
            }
            double max_number = 0;
            double min_number = 0;
            bool total = false;
            for(int l = 0; l < row; l++)
            {
                for(int k = 0; k < col; k++)
                {
                    for(int i = 0;  i < n; i++)
                    {
                        if (B[l, k] == A[i] && max_number < A[i])
                        {
                            total = true;
                            max_number = A[i];
                        }
                        else if (B[l, k] == A[i] && min_number < A[i])
                        {
                            total = true;
                            min_number = A[i];
                        }
                      
                    }
                }
            }
            if (total)
            {
                Console.WriteLine($"Общее максимальное значение: {max_number}");
                Console.WriteLine($"Общее минимальное значение: {min_number}"); 
            }
            else Console.WriteLine($"Нет общих значений");
        }
    }
};
