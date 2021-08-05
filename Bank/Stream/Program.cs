using System;
using System.IO;
using System.Text;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var sw = new StreamWriter("test.txt",true,Encoding.UTF8))
            {
                sw.Write("Hello, World!");
                sw.WriteLine("Hello, user!");
                sw.WriteLine("Привет, Мир!");
            }
            using (var sr = new StreamReader("test.txt", Encoding.UTF8))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
       
    }
}
