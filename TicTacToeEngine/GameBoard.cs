using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.TicTacToe.GameApp
{
    internal sealed class GameBoard //Create GameBoard
    {
        
        private GameBoard()
        {
           
        }
        public static string[,] GetBoard()
        {
             string[,] board = new string[3, 3]
            {
                {"-","-","-"},
                {"-","-","-"},
                {"-","-","-"}
            };

            return board;
        }
    }
}
