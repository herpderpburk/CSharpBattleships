using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Player
    {

        char[,] Sea = new char[10, 10];
        char[,] Sea2 = new char[10, 10];
        public int hitCount = 0;
        public int missCount = 0;
        public int totalWins;
        public int totalLosses;
        public double hitPercentage;
        public double winLossRatio;
        int x = 0;
        int y = 0;

        public int getHitCount()
        {
            return hitCount;
        }
        public int getMissCount()
        {
            return missCount;
        }
        public int getTotalWins()
        {
            return totalWins;
        }
        public int getTotalLosses()
        {
            return totalLosses;
        }
        public double getWinLossRatio()
        {
            return ((double)winLossRatio / ((double)(totalWins + totalLosses))) * 100.0; ;
        }
        public double getHitPercentage()
        {
            return ((double)hitCount / ((double)(hitCount + missCount))) * 100.0; ;
        }


        public void PlayMove()
        {
            Console.WriteLine("Enter X coordinate.");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                x = value;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("Enter Y coordinate.");
            line = Console.ReadLine();
            if (int.TryParse(line, out value))
            {
                y = value;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            try
            {
                if (Sea[x, y].Equals('S'))
                {
                    Sea[x, y] = 'H';
                    Console.Clear();
                    Console.WriteLine("Hit!\r\n");
                    hitCount += 1;
                }
                else
                {
                    Sea[x, y] = 'M';
                    Console.Clear();
                    Console.WriteLine("Miss!\r\n");
                    missCount += 1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error: Illegal move. Please enter numbers between 0 and 9.");
            }
        }
        public char[,] getSea()
        {
            return Sea;
        }
        public void setSea(int q, int w)
        {
            Sea[q, w] = 'S';
        }
        public char[,] getSea2()
        {
            return Sea2;
        }
        public void setSea2(int q, int w)
        {
            Sea2[q, w] = 'S';
        }
        public void Randomise()
        {

            {
                Random r = new Random(2);
                //aircraft carrier - 5 squares long
                setSea(0, 5);
                setSea(1, 5);
                setSea(2, 5);
                setSea(3, 5);
                setSea(4, 5);
                //battleship
                setSea(7, 4);
                setSea(7, 5);
                setSea(7, 6);
                setSea(7, 7);
                //submarine
                setSea(0, 8);
                setSea(1, 8);
                setSea(2, 8);
                //destroyer
                setSea(9, 0);
                setSea(9, 1);
                setSea(9, 2);
                //patrol boat
                setSea(3, 3);
                setSea(3, 2);
                setSea(3, 1);

            }

            {
                Random r2 = new Random(2);
                //aircraft carrier - 5 squares long
                setSea2(0, 5);
                setSea2(1, 5);
                setSea2(2, 5);
                setSea2(3, 5);
                setSea2(4, 5);
                //battleship
                setSea2(7, 4);
                setSea2(7, 5);
                setSea2(7, 6);
                setSea2(7, 7);
                //submarine
                setSea2(0, 8);
                setSea2(1, 8);
                setSea2(2, 8);
                //destroyer
                setSea2(9, 0);
                setSea2(9, 1);
                setSea2(9, 2);
                //patrol boat
                setSea2(3, 3);
                setSea2(3, 2);
                setSea2(3, 1);
            }



        }
    }//end of player class
}
