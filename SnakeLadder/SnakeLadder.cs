using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeLadder
    {
        public const int Noplay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;

        public void StartGame()
        {
            Random random = new Random();
            int Position = 0;
            int dice;
            int option;
            int numOfDiceRoll = 0;
          
            while (Position < 100)
            {
                Console.WriteLine("Player now at position: " + Position);
                dice = random.Next(1, 7);
                numOfDiceRoll++;
                Console.WriteLine("\n\nNumber appeared in dice is:" + dice);              
                option = random.Next(0, 3);
 
                if (option == Ladder)
                {
                    if ((Position + dice) > 100)
                    {
                        Position = 100;
                        Console.WriteLine("Player moves to 100th position");
                    }
                    else
                    {
                        Position += dice;
                    }
                }

                else if (option == Snake)
                {
                    if (Position < dice)
                    {
                        Position = 0;
                    }
                    else
                    {
                        Position -= dice;
                    }
                }
                else
                {
                    Position = Position;
                }

            }
            Console.WriteLine("Player reaches at: " + Position);
            Console.WriteLine("The number of times dice was played: " + numOfDiceRoll);

        }
    }
}
