using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Delegate;

namespace Tic_Tac_Toe
{
    public delegate void Print(string smth);
    public delegate void PrintPlayer(char player);
    class Board:Game
    {
		public Print print;
		public PrintPlayer PrintP;

        public override void PrintField(char[] Field, char player)
        {
			Console.Clear();
			int counter = 0;
			print("\t\t\t\t\t\t╔");
			//Console.Write("╔");
			for (int i = 0; i < 9; i++)
			{
				print("═");
			}
			print("╗\n");
			print("\t\t\t\t\t\t");
			print("║");
			for (int i = 0; i < 9; i++)
			{
				if (Field[i] == 1)
				{
					PrintP(player);
				}
				
				counter++;
				if (counter == 3 || counter == 6)
				{
					print("║");
					print("\t\t\t\t\t\t\n");
					print("\t\t\t\t\t\t\n");
					print("║");
				}
				if (counter == 9)
				{
					print("║\n");
				}
			}
			print("\t\t\t\t\t\t");
			print("╚");
			for (int i = 0; i < 9; i++)
			{
				print("═");
			}
			print("╝\n");
			Check(Field,player);
		}
	}
    
}
