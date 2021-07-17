using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Delegate;

namespace Tic_Tac_Toe
{
 
    class Board
    {
		
		public Board()
        {
			
        }
        public void PrintField(char[] Field, char player)
        {
			Console.Clear();
			Console.Write("\n\n\n\n\n\n\n\n");
			for (int i = 6; i >= 0; i -= 3)
			{
				Console.Write("\t\t\t\t\t\t ");

				for (int j = 0; j < 3; j++)
				{
					Console.Write($" {Field[i + j]}");
					if (j != 2) Console.Write(" | ");
				}
				Console.WriteLine();

				Console.Write("\t\t\t\t\t\t ");
				if (i != 0) Console.Write("--- --- ---");
				Console.WriteLine();

			}
			
		}
	}
    
}
