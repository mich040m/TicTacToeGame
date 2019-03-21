using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.TicTacToe.GameApp
{
    public class GameLogic
    {
        private string[,] _board;
        private bool _winner;

        public string[,] Board { get => _board; private set => _board = value; }
        public bool Winner { get => _winner; private set => _winner = value; }
        public GameLogic()
        {
            Board = GameBoard.GetBoard();
        }

        public void MakeMove(string[] move, string piece)
        {
            Board[ConvertYCoodrinates(Convert.ToInt32(move[1]) - 1), (Convert.ToInt32(move[0]) - 1)] = piece;
        }
        public string GetWinner()
        {
            string firstLine = Board[0, 0] + Board[0, 1] + Board[0, 2];
            string secoundLine = Board[1, 0] + Board[1, 1] + Board[1, 2];
            string thirdLine = Board[2, 0] + Board[2, 1] + Board[2, 2];

            string firstDownLine = Board[0, 0] + Board[1, 0] + Board[2, 0];
            string secoundDownLine = Board[0, 1] + Board[1, 1] + Board[2, 1];
            string thirdDownLine = Board[0, 2] + Board[1, 2] + Board[2, 2];

            string aCrossLineFirst = Board[0, 0] + Board[1, 1] + Board[2, 2];
            string aCrossLineSecound = Board[0, 2] + Board[1, 1] + Board[2, 0];

            if (firstLine == "XXX" || secoundLine == "XXX" || thirdLine == "XXX" || aCrossLineFirst == "XXX" || aCrossLineSecound == "XXX" ||
                firstDownLine == "XXX" || secoundDownLine == "XXX" || thirdDownLine == "XXX" )
            {
                Winner = true;
                return "X";
            } else if (firstLine == "OOO" || secoundLine == "OOO" || thirdLine == "OOO" || aCrossLineFirst == "OOO" || aCrossLineSecound == "OOO" ||
                firstDownLine == "OOO" || secoundDownLine == "OOO" || thirdDownLine == "OOO")
            {
                Winner = true;
                return "O";
            } else
            {
                return string.Empty;
            }
        }
        public bool IsValidMove(string[] move)
        {
 
            if (Board[ConvertYCoodrinates(Convert.ToInt32(move[1]) - 1), (Convert.ToInt32(move[0]) - 1)] == "-")
                return true;
            else return false;
        }

        private static int ConvertYCoodrinates(int temp)
        {
            switch (temp)
            {
                case 0:
                    temp = 2;
                    break;
                case 2:
                    temp = 0;
                    break;
                default:
                    break;
            }

            return temp;
        }
        
    }
}
