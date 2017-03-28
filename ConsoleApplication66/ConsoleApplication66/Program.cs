using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            var game = new Game3(p);
         //  game.mixer(p);
            ConsoleGameUI Menu = new ConsoleGameUI(game);
            Menu.GetMenu();

        }
    }
}