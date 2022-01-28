using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProblem
{
    class SnakeAndLaddeGame
    {
        const int NOPLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION=100;
        int player_pos = 0, count=0;
        Random random = new Random();
        public int DiceRoll()
        {
            count++;
            return random.Next(1, 7);
        }
       
        public void Play()
        {
            while (this.player_pos != WINNING_POSITION)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NOPLAY:
                        //Console.WriteLine("The player stays in the same position");
                        break;
                    case LADDER:
                        if(this.player_pos + DiceRoll() < 100)
                        {
                            this.player_pos += DiceRoll();
                        }
                        break;
                    case SNAKE:
                        if (this.player_pos + DiceRoll() >= 0)
                        {
                            this.player_pos -= DiceRoll();
                        }
                        else
                        {
                            this.player_pos = 0;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Player position"+ this.player_pos);
            }
            Console.WriteLine("Number of time Dice Rolled"+ count);
           
        }
    }
}
