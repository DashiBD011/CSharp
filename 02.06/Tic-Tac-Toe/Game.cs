using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace Tic_Tac_Toe
{
    public delegate string Message(string msg);
    public delegate string ReadLine();

    public class Game
    {


        const char X = 'X';
        const char O = 'O';

        protected char player = X;
        int turn;

        protected char[] Field = new char[9];

        public Message Info;
        public Message Error;

        public void Move(char[] Field, char player)
        {
            bool busy;

            do
            {
                busy = false;
                Info("Введите число от 1-9");
                turn = Int32.Parse(ReadLine());
                do
                {
                    if (turn < 1 || turn > 9)
                    {
                        Error("Неправильный ход");
                    }

                } while (turn < 1 || turn > 9);

                if (Field[turn - 1] != 0)
                {
                    busy = true;
                    Error("Клетка уже занята");
                }
                else Field[turn - 1] = player;



            } while (busy);
            PrintField(Field, player);

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
                Info("Ничья!");
            }

            if (game_over)
            {
                Info($"{player} wins");
            }
            else
            {
                if (player == X)
                {
                    player = O;
                }

                else
                {
                    player = X;
                }
                Move(Field, player);
            }

        }

        public virtual void PrintField(char[] Field, char player)
        { 

        }

    }
}
