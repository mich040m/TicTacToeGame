using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.TicTacToe.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
        private void Run()
        {
            ConsoleGameUI c = new ConsoleGameUI();
            c.Run();
        }
    }
}
