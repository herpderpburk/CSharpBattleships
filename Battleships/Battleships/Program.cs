using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   
        public class Program
        {

            static void Main(string[] args)
            {

                Console.Title = "Battleships";
                Console.WriteLine("Battleships!\r\n\r\n");
                Console.WriteLine("Player 1, what is your name?");
                string name = System.Console.ReadLine();
                Console.WriteLine("Player 2, what is your name?");
                string player2Name = System.Console.ReadLine();
                Console.WriteLine();
                Battleships s = new Battleships();
                Player p = new Player();
                Battleships s2 = new Battleships();
                Player p2 = new Player();
                p.Randomise();
                p2.Randomise();

                while (p.getHitCount() < 17)
                    while (p2.getHitCount() < 17)
                    //place askcoordinates method inside here
                    {
                        s.placeSea(p.getSea());
                        p.PlayMove();
                        s.placeSea2(p2.getSea());
                        p2.PlayMove();
                    }

           
                {
                    Console.WriteLine("Congratulations, " + name + "! You beat " + player2Name + "!\r\n");
                    Console.WriteLine("You successfully hit: " + p.getHitCount() + " targets.\r\n");
                    Console.WriteLine("You missed: " + p.getMissCount() + " times.\r\n");
                    Console.WriteLine("Hit percentage: " + p.getHitPercentage() + "% \r\n");
                    Console.WriteLine("You won:" + p.getTotalWins() + "games.\r\n");
                    Console.WriteLine("You lost:" + p.getTotalLosses() + "games.\r\n");
                    Console.WriteLine("Your W/L ratio is:" + p.getWinLossRatio());
                    Console.WriteLine("Thanks for playing Battleships. Press enter to quit.");
                    System.Console.ReadLine();
                }

                if
                   (p2.getHitCount() < 17)
                {
                    Console.WriteLine("Congratulations, " + player2Name + "! You beat " + name + "!\r\n");
                    Console.WriteLine("You successfully hit: " + p2.getHitCount() + " targets.\r\n");
                    Console.WriteLine("You missed: " + p2.getMissCount() + " times.\r\n");
                    Console.WriteLine("Hit percentage: " + p2.getHitPercentage() + "% \r\n");
                    Console.WriteLine("You won:" + p2.getTotalWins() + "games.\r\n");
                    Console.WriteLine("You lost:" + p2.getTotalLosses() + "games.\r\n");
                    Console.WriteLine("Your W/L ratio is:" + p2.getWinLossRatio());
                    Console.WriteLine("Thanks for playing Battleships. Press enter to quit or Space for a new game.");
                    System.Console.ReadLine();
                    
                }
            }//end of Main
        } 
}
