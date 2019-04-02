using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cards = new MyCards();
            //var output = new Output();

            //var a = output.OnePair;
            //var b = output.TwoPair;
            //var c = output.ThreeOfAKind;
            //var d = output.Flush;
            //var e = output.FourOfAKind;
            //var f = output.FullHouse;
            var game = new Game();
            game.Start();

        }
    }
}
