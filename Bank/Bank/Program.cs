using System;
using System.IO;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string FName;
            string LName;
            uint Age;
            int m = 3;
            int d;
            int current_acc = 0;

            Account[] acc = new Account[m];
            for (int i = 0; i < m; i++)
            {
                acc[i] = new Account();
            }
            acc[current_acc].info = ShowConsoleInfo;
            acc[current_acc].Error = ShowConsoleError;

            Console.WriteLine("Приветсвуем в банке Закрытие!");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1) Создать новый аккаунт;\n2)Выбрать аккаунт");
            for (; ; )
            {
                int n = Convert.ToInt32(Console.ReadLine());
                //if (n == 1)
                //{
                //    Console.Clear();
                //    Console.Write("Введите имя: ");
                //    FName = Console.ReadLine();
                //    Console.Write("Введите фамилию: ");
                //    LName = Console.ReadLine();
                //    Console.Write("Введите возраст: ");
                //    Age = Convert.ToUInt32(Console.ReadLine());
                //    if (Age < 14)
                //    {
                //        Console.WriteLine("\nВы слишком молод");
                //        return;
                //    }
                //    for (int i = 0; i < m; i++)
                //    {
                //        if (!(acc[i].Getacc()))
                //        {
                //            acc[i] = new Account(LName, FName, Age);
                //            current_acc = i;
                //            break;
                //        }
                //    }

                //    Console.Clear();
                //    Console.WriteLine("\nАккаунт успешно создан!");
                //    Console.WriteLine(acc[current_acc].Info());

                //}
                //else if (n == 2)
                //{
                //    d = 0;
                //    Console.Clear();
                //    foreach (var item in acc)
                //    {
                //        if (item.Getacc())
                //        {
                //            d++;
                //            Console.WriteLine($"{d}) {item.InfoPerson()}");
                //        }
                //    }
                //    if (d == 0) 
                //    {
                //        Console.WriteLine("Сначала создайте аккаунт");
                //        return;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Выберите аккаунт: ");
                //        d = Convert.ToInt32(Console.ReadLine());
                //        if (d == 1)
                //        {
                //            current_acc = 0;
                //            Console.WriteLine("Вы выбрали аккаунт: ");
                //            Console.WriteLine(acc[current_acc].InfoPerson());
                //        }
                //        else if (d == 2)
                //        {
                //            if (acc[1].Getacc())
                //            {
                //                current_acc = 1;
                //                Console.WriteLine("Вы выбрали аккаунт: ");
                //                Console.WriteLine(acc[current_acc].InfoPerson());
                //            }
                //            else return;
                //        }
                //        else if (d == 3)
                //        {
                //            if (acc[2].Getacc())
                //            {
                //                current_acc = 2;
                //                Console.WriteLine("Вы выбрали аккаунт: ");
                //                Console.WriteLine(acc[current_acc].InfoPerson());
                //            }
                //            else return;
                //        }
                //        else return;
                //    }
                //    Console.Clear();
                //    Console.WriteLine("Выберите операцию: \n1)Посмотреть баланс\n2)Пополнить\n3)Снять\n4)Удалить аккаунт");
                //    d = Convert.ToInt32(Console.ReadLine());

                //}
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Введите имя: ");
                        FName = Console.ReadLine();
                        Console.Write("Введите фамилию: ");
                        LName = Console.ReadLine();
                        Console.Write("Введите возраст: ");
                        Age = Convert.ToUInt32(Console.ReadLine());
                        if (Age < 14)
                        {
                            Console.WriteLine("\nВы слишком молод");
                            return;
                        }
                        for (int i = 0; i < m; i++)
                        {
                            if (!(acc[i].Getacc()))
                            {
                                acc[i] = new Account(LName, FName, Age);
                                current_acc = i;
                                break;
                            }
                        }

                        Console.Clear();
                        Console.WriteLine("\nАккаунт успешно создан!");
                        Console.WriteLine(acc[current_acc].Info());
                        break;

                    case 2:
                        d = 0;
                        Console.Clear();
                        foreach (var item in acc)
                        {
                            if (item.Getacc())
                            {
                                d++;
                                Console.WriteLine($"{d}) {item.InfoPerson()}");
                            }
                        }
                        if (d == 0)
                        {
                            Console.WriteLine("Сначала создайте аккаунт");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Выберите аккаунт: ");
                            d = Convert.ToInt32(Console.ReadLine());
                            if (d == 1)
                            {
                                current_acc = 0;
                                Console.WriteLine("Вы выбрали аккаунт: ");
                                Console.WriteLine(acc[current_acc].InfoPerson());
                            }
                            else if (d == 2)
                            {
                                if (acc[1].Getacc())
                                {
                                    current_acc = 1;
                                    Console.WriteLine("Вы выбрали аккаунт: ");
                                    Console.WriteLine(acc[current_acc].InfoPerson());
                                }
                                else return;
                            }
                            else if (d == 3)
                            {
                                if (acc[2].Getacc())
                                {
                                    current_acc = 2;
                                    Console.WriteLine("Вы выбрали аккаунт: ");
                                    Console.WriteLine(acc[current_acc].InfoPerson());
                                }
                                else return;
                            }
                            else return;
                        }
                        break;
                }
                Console.Clear();
                Console.WriteLine("Выберите операцию: \n1)Посмотреть баланс\n2)Пополнить\n3)Снять\n4)Удалить аккаунт");
                d = Convert.ToInt32(Console.ReadLine());
                switch (d)
                {
                    case 1:
                        acc[current_acc].ShowBalance();
                        //Console.WriteLine($"{ acc[current_acc].GetBalance()}");
                        break;
                    case 2:break;
                }
                Console.WriteLine("fff");
            }


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
