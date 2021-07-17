using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace Tic_Tac_Toe
{

    public class Game
    {
        protected char[] Field = new char[9];
        protected char player;
        private int turn;

        public Game()
        {

        }
        public void Start()
        {
            ConsoleKeyInfo cki;
            int count = 0;
            Board board = new Board();
            cki = Console.ReadKey(true);
            do
            {
                if (count % 2 == 0) player = 'X';
                else player = 'O';
                board.PrintField(Field, player);
                Move(Field, player);
                Check(Field, player);
                count++;
            } while (cki.Key != ConsoleKey.Escape);
        }
        public void Move(char[] Field, char player)
        {
            bool busy;

            do
            {
                busy = false;
                Console.WriteLine("Введите число от 1 до 9");
                turn = Int32.Parse(ReadLine());
                if (turn < 1 || turn > 9)
                {
                    Console.WriteLine("Неправильный ход");
                }


                if (Field[turn - 1] != 0)
                {
                    busy = true;
                    Console.WriteLine("Клетка уже занята");
                }
                else Field[turn - 1] = player;



            } while (busy);

        }
        public void Check(char[] Field, char player)
        {
            bool game_over = false;
            bool drawn_game = true;

            if (Field[0] == Field[4] && Field[4] == Field[8] && Field[0] != 0 ||
                Field[0] == Field[1] && Field[1] == Field[2] && Field[0] != 0 ||
                Field[0] == Field[3] && Field[3] == Field[6] && Field[0] != 0 ||
                Field[2] == Field[4] && Field[4] == Field[6] && Field[2] != 0 ||
                Field[2] == Field[5] && Field[5] == Field[8] && Field[2] != 0 ||
                Field[4] == Field[3] && Field[3] == Field[5] && Field[4] != 0 ||
                Field[4] == Field[1] && Field[1] == Field[7] && Field[4] != 0 ||
                Field[7] == Field[6] && Field[6] == Field[8] && Field[7] != 0)
            {
                game_over = true;
            }

            for (int i = 0; i < 9; i++)
            {
                if (Field[i] == 0) drawn_game = false;
            }
            if (!game_over && drawn_game)
            {
                Console.WriteLine("Ничья!");
            }

            if (game_over)
            {
                Console.WriteLine($"{player} wins");
                return;
            }
            else
            {
                if (player == 'X')
                {
                    player = '0';
                }

                else
                {
                    player = 'X';
                }
            }

        }

       

    }
}
