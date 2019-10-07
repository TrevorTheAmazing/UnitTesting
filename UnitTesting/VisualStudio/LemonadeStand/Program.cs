using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game;

namespace LemonadeStand
{
    class Program
    {        
        static void Main(string[] args)
        {
            Random random = new Random();
            Game game = new Game(random);
            Console.WriteLine("Game Over.");
            Console.ReadLine();
        }
    }
}
