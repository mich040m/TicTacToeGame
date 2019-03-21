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
        internal void Run()
        {
            game = new GameLogic();
            RenderBody(game.Board);
            while(!game.IsValidMove(MoveCoords()))
            {
                
                game.MakeMove(MoveCoords(), "X");
            }
            
            RenderBody(game.Board);
            Console.ReadLine();
        }
        private void RenderBody(string[,] board)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  1,2,3");
            Console.WriteLine("________");
            Console.WriteLine();
            Console.WriteLine($"1|{board[0, 0]} {board[0, 1]} {board[0, 2]}|");
            Console.WriteLine($"2|{board[1, 0]} {board[1, 1]} {board[1, 2]}|");
            Console.WriteLine($"3|{board[2, 0]} {board[2, 1]} {board[2, 2]}|");
            Console.WriteLine("________");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
        }
        private string[] MoveCoords()
        {
            string[] move = new string[2];
            Console.Write("Please Write The X Coordinates: ");
            move[0] = Console.ReadLine();
            Console.Write("Please Write The Y Coordinates: ");
            move[1] = Console.ReadLine();
            return move;
        }
        
    }
}
