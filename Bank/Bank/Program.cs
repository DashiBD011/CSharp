using System;
using System.IO;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.info = ShowConsoleInfo;
            acc.Error = ShowConsoleError;

            string LName;
            string FName;
            uint Age;
            uint choice;
            bool is_empty = true;
            for (;;)
            {
            m:
                if (File.ReadAllLines("account.bin").Length != 0)
                {
                    is_empty = false;
                }

                Console.WriteLine("Здравствуйте!");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1) Создать аккаунт");
                if (!is_empty)
                {
                    Console.WriteLine("2) Продолжить с существующим");
                    Console.WriteLine("3) Удалить аккаунт");
                }
                Console.WriteLine("0, чтобы выйти");
                choice = Convert.ToUInt32(Console.ReadLine());
                if (is_empty && choice > 1) break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите имя: "); 
                        FName = Console.ReadLine();
                        Console.Write("Введите фамилию: ");
                        LName = Console.ReadLine();
                        Console.Write("Введите возвраст: ");
                        Age = Convert.ToUInt32(Console.ReadLine());
                        if (Age < 14)
                        {
                            Console.WriteLine("Вы слишком молод");
                            break;
                        }
                        break;
                    case 2: acc = acc.ReadFromFile(); break;
                    case 3: acc.DeleteAcc(); goto m;
                    case 0: return;
                    default: acc.Error("Такого варианта нет"); goto m;
                }
                Console.Clear();
                Console.WriteLine(acc.Info());
                Console.WriteLine("Выберите операцию: ");
                Console.WriteLine("1)Пополнить");
                Console.WriteLine("2)Вывести");
                Console.WriteLine("0)Выйти");


                choice = Convert.ToUInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: acc.TopUp(); break;
                    case 2: acc.Withdraw(); break;
                    case 0: acc.WriteToFile(); break ;
                    default: acc.Error("Такого варианта нет"); break;
                }
                acc.WriteToFile();

            } 
        }
        static void ShowConsoleInfo(string msg)
        {
            Console.WriteLine(msg);
        }
        static void ShowConsoleError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }


    }

}
