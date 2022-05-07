using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackDieRoll
{
    public class Ladder
    {
        const int Snake = 1;
        const int Laddr = 2;
        const int No_play = 0;
        public int Position = 0;
        public int Count = 0;
        public int totalPostion = 0;

        public void Game()
        {
            while (Position < 100)
            {
                Random rand = new Random();
                int dice = rand.Next(1, 7);
                Console.WriteLine("Dice Number= " + dice);

                int option = rand.Next(0, 3);
                Console.WriteLine("Option= " + option + " " + " 0-NoPlay, 1-Snake, 2-Ladder");

                switch (option)
                {
                    case 0:
                        Position += 0;
                        Console.WriteLine("Current Position is " + Position);
                        break;
                    case 1:
                        if (Position > dice)
                        {
                            Position -= dice;
                            Console.WriteLine("Current Position is " + Position);
                        }
                        else if (Position < dice)
                        {
                            Position = 0;
                            Console.WriteLine("Current Position is " + Position);
                        }

                        break;
                    case 2:
                        Position += dice;
                        Console.WriteLine("Current Position is " + Position);
                        break;
                }
                Count++;

                if (Position > 100)
                {
                    Position -= dice;
                }
                else if (Position == 100)
                {
                    Console.WriteLine("Win");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("total Number" + Count);
        }
    }
}