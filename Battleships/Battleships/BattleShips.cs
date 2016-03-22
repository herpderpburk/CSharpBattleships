using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Battleships
    {

        static int[,] sea = new int[10, 10];//declares a 10x10 sea. 2D array

        public static void clearSea()
        {
            for (int x = 0; x < 10; x = x++)//clears the sea line-by-line
            {
                sea[x, 0] = 0;
            }
            for (int y = 0; y < 10; y = y++)//clears the sea line-by-line
            {
                sea[y, 0] = 0;
            }

        }

        public void placeSea(char[,] Sea)//place sea onto console
        {
            int Row;
            int Column;
            Console.WriteLine("Player 1");
            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------");
            for (Row = 9; Row > -1; Row--)//how do i do my ABCs? 
            {
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    Console.Write(Sea[Column, Row] + " ");
                }
                Console.WriteLine();
            }
        }

        public void placeSea2(char[,] Sea2)//place player 2 sea onto console after player 1 has had their turn
        {
            int Row;
            int Column;
            Console.WriteLine("Player 2");
            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+--------------------");
            for (Row = 9; Row > -1; Row--)//how do i do my ABCs? 
            {
                Console.Write((Row).ToString() + "¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    Console.Write(Sea2[Column, Row] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
