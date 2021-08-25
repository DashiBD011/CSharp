using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleEmulator
{
    public delegate void Message(string msg);
    public class Emulator
    {
        public Message Info;
        public Message Error;

        public void ShowConsole()
        {
            Console.WriteLine("Console Emulator\n");
            
            ShowCommand("\t--help\t","Показать команды\n");

            ShowCommand("\t--sp\t","Вывод полного пути, где сейчас находитесь в структуре каталогов\n");

            ShowCommand("\t--scd\t","Переход в указанный каталог");
            ShowCommand("\t--copy\t","Копирование в указанное место\n");

            ShowCommand("\t--cf\t","Создание текстового файла");
            ShowCommand("\t--del\t","Удаление файла\n");

            ShowCommand("\t--sfc\t","Вывод содержмого текстового файла на консоль\n");

            ShowCommand("\t--exit\t", "Выйти");
              
        }
        public string ShowPath()
        {
            return Directory.GetCurrentDirectory();
        }
        public void SetDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.SetCurrentDirectory(path);
            }
            else Error("Такого каталога не существует");
        }
        public void Copy(string source, string dest)
        {
            if (source == dest) return;
            if (!Directory.Exists(dest)) Error("Указанный путь не существует");
            if (File.Exists(source))
            {
                File.Copy(source, dest,true);
            }
            //else Error("Такого файла не существует");
        }
        public void CreateFile(string name)
        {
            using var file = new StreamWriter(name, true);
            Info("Файл создан");
        }
        public void DeleteFile(string path)
        {
            File.Delete(path);
            Info("Файл удален");
        }
        public string ReadFromFile(string path)
        { 
            string text;
            return text = File.ReadAllText(path);
        }
        private void ShowCommand(string comm, string value)
        {
            Console.Write(comm);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(value);
            Console.ResetColor();
        }

    }
}
