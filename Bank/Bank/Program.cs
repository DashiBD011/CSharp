using System;
using System.IO;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string LName;
            string FName;
            uint Age;

            Console.WriteLine("1)Создать аккаунт2)");
            Console.Write("Введите имя: ");
            FName = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            LName = Console.ReadLine();
            Console.Write("Введите возраст: ");
            Age = Convert.ToUInt32(Console.ReadLine());
            if (Age < 14)
            {
                Console.WriteLine("Вы слишком молод");
                return;
            }
            Account acc = new Account(LName, FName, Age);
            Console.Clear();
            Console.WriteLine("Аккаунт создан!");
            


        }
        static void ShowConsoleInfo(string msg)
        {
            Console.WriteLine(msg);
        }
        static void ShowConsoleError(string msg)
        {
            Console.WriteLine(msg);
        }
        

    }

}
