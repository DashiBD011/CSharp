using System;
using System.IO;

namespace Stream
{
    class Program
    {
        static void Main()
        {
            var disks = DriveInfo.GetDrives();
            foreach (var disk in disks)
            {
                Console.WriteLine($"Disk name : {disk.Name}");
                Console.WriteLine($"Volume label : {disk.VolumeLabel}");
                Console.WriteLine($"Type : {disk.DriveType}");
                Console.WriteLine($"Format : {disk.DriveFormat}");
                Console.WriteLine($"Total size : {disk.TotalSize}");
                var rootPath = disk.RootDirectory.ToString();
                var files = Directory.GetFiles(rootPath);
                foreach (var file in files)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Type : {file.GetType()}");
                    Console.WriteLine(file);
                    Console.ResetColor();
                }
                var dirs = Directory.GetDirectories(rootPath);
                foreach (var dir in dirs)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Type : {dir.GetType()}");
                    Console.WriteLine(dir);
                }
            }
        }
       
    }
}
