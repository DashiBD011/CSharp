using System;
using System.IO;

namespace ConsoleEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string path;
            bool exit = false;
            Emulator em = new Emulator();

            em.Info = ShowInfo;
            em.Error = ShowError;

            em.ShowConsole();

            while (!exit)
            {
                Console.Write("\nВведите команду: ");
                command = Console.ReadLine();
                switch (command)
                {
                    case "help": em.ShowConsole(); break;

                    case "sp": Console.WriteLine(em.ShowPath()); break;

                    case "scd":
                        Console.Write("Введите путь ");
                        path = Console.ReadLine().ToString();
                        em.SetDirectory(path);
                        break;

                    case "copy":
                        string path1;
                        string path2;
                        Console.Write("Откуда: ");
                        path1 = Console.ReadLine().ToString();
                        Console.Write("Куда: ");
                        path2 = Console.ReadLine().ToString();
                        em.Copy(path1, path2);
                        break;

                    case "cf":
                        string name;
                        Console.Write("Введите имя файла: ");
                        name = Console.ReadLine().ToString();
                        em.CreateFile(name);
                        break;

                    case "del":
                        Console.Write("Введите путь ");
                        path = Console.ReadLine();
                        em.DeleteFile(path);
                        break;

                    case "sfc":
                        Console.Write("Введите путь: ");
                        path = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine(em.ReadFromFile(path));
                        break;

                    case "exit": exit = true; break;
                    default:
                        ShowError("Неизвестная команда");
                        break;
                }
            }

        }
        static void ShowInfo(string msg)
        {
            Console.WriteLine(msg);
        }
        static void ShowError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}

/*
   Основные команды (действия):

   1)вывод полного пути, где сейчас находитесь в структуре каталогов
   2)переход в указанный каталог
   3)создание текстового файла
   4)копирование в указанное место
   5)удаление файла
   6)вывод на экран консоли/терминала содержимого текстового файла
 */