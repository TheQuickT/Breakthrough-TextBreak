using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough_Text_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start up the game via instance creation and then method call
            Game game = new Game();

            game.PlayGame();
        }
    }
}
