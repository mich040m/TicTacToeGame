using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompany.TicTacToe.GameApp;

namespace MyCompany.TicTacToe.UI
{
    internal sealed class ConsoleGameUI
    {
        private GameLogic game;
        private char[] _legalChoices = {'1', '2', '3',};
        private const int MAX_MOVES = 0;
        internal void Run()
        {
            int moveCount = 0;
            game = new GameLogic();
            RenderBody(game.Board);
            while (game.Winner == false || moveCount != MAX_MOVES)
            {
                PlayerMove("X");
                moveCount++;
                PlayerMove("O");
                moveCount++;
            }
            
            Console.WriteLine($"Winner is: {game.GetWinner()} !!!");
        }

        private void PlayerMove(string piece)
        {
            
            if (game.Winner == false)
            {
                
                game.MakeMove(MoveCoords(), piece);
                Console.Clear();
                RenderBody(game.Board);
                game.GetWinner();
            }
        }

        private void RenderBody(string[,] board)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  1,2,3");
            Console.WriteLine("________");
            Console.WriteLine();
            Console.WriteLine($"3|{board[0, 0]} {board[0, 1]} {board[0, 2]}|3");
            Console.WriteLine($"2|{board[1, 0]} {board[1, 1]} {board[1, 2]}|2");
            Console.WriteLine($"1|{board[2, 0]} {board[2, 1]} {board[2, 2]}|1");
            Console.WriteLine("________");
            Console.WriteLine("  1,2,3");
            Console.WriteLine("------------------------------------");
        }
        private string[] MoveCoords()
        {
            string[] move = new string[2];
            char input;
            bool ok;
            bool check;
            do
            {
            GetValidInput(out input, out ok, "X");
            move[0] = input.ToString();

            GetValidInput(out input, out ok, "Y");
            move[1] = input.ToString();
                check = game.IsValidMove(move);
                if (!check)
                {
                    Console.WriteLine("Move is ilegal");
                }
            } while (!check);
            return move;
        }

        private void GetValidInput(out char input, out bool ok, string coordinate)
        {
            do
            {
                Console.Write($"Please Write The {coordinate} Coordinates: ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                ok = _legalChoices.Contains<char>(input);
                if (!ok)
                {

                    Console.WriteLine($"Input is not correct; {input} is not a valid choice. Try Again");

                }
            } while (!ok);
        }
    }
}
