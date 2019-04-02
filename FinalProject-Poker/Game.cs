using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Poker
{
    class Game
    {
        public MyPlayer MyPlayer { get; set; } = new MyPlayer(null);

        public Game()
        {
            
        }



        public void Start()
        {
            MyPlayer[] myPlayers = new MyPlayer[5];
            
            Console.WriteLine("Welcome");
            Console.WriteLine("Please enter your name:");

            MyPlayer.Name = Console.ReadLine();

            Console.WriteLine("********** Hello " + MyPlayer.Name + " **********");

            myPlayers[0] = new MyPlayer("Sam");
            myPlayers[1] = new MyPlayer("Jacky");
            myPlayers[2] = new MyPlayer("Roi");
            myPlayers[3] = new MyPlayer("Sid");
            myPlayers[4] = MyPlayer;

            foreach (var myPlayer in myPlayers)
            {
                Console.WriteLine(myPlayer.Name);
            }
            

            //Main();
        }

        public void Main()
        {
            var input = "0";

            while (input != "3")
            {
                Console.WriteLine("Please choose an option by entering a number.");
                Console.WriteLine("1. ");

                Console.WriteLine("3. Exit");

                input = Console.ReadLine();

                if (input == "1")
                {
                    
                }
                
            }
        }
    }
}
