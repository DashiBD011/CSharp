using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Test
{
    public delegate void Print(string smth);
    class Class1
    {
		char[] Field = new char[9];

        public Class1()
        {
			PrintField(Field);
        }
        public void PrintField(char[] Field)
        {
			int counter = 0;
			Console.Write("\t\t\t\t\t\t╔");

			for (int i = 0; i < 9; i++)
			{
				Console.Write("═");
			}
			Console.WriteLine("╗");
			Console.Write("\t\t\t\t\t\t");
			Console.Write("║");
			for (int i = 0; i < 9; i++)
			{
				

				counter++;
				if (counter == 3 || counter == 6)
				{
					Console.Write("║");
					Console.WriteLine("\t\t\t\t\t\t");
					Console.WriteLine("\t\t\t\t\t\t");
					Console.Write("║");
				}
				if (counter == 9)
				{
					Console.WriteLine("║");
				}
			}
			Console.Write("\t\t\t\t\t\t");
			Console.Write("╚");
			for (int i = 0; i < 9; i++)
			{
				Console.Write("═");
			}
			Console.WriteLine("╝");
		}

    }
}
