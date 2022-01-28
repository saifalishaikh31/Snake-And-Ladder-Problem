using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProblem
{
    class SnakeAndLaddeGame
    {
        const int NOPLAY = 0, LADDER = 1, SNAKE = 2;
        int player_pos = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            return random.Next(1, 7);
        }
        
        public void Play()
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case NOPLAY:
                    Console.WriteLine("The player stays in the same position");
                    break;
                case LADDER:
                    
                    this.player_pos += DiceRoll();
                    Console.WriteLine("The player moves ahead by the number of position received in the die : " + player_pos);
                    break;
                case SNAKE:
                    this.player_pos -= DiceRoll();
                    Console.WriteLine("The player moves behind by the number of position received in the die : " + player_pos);
                    break;
                default:
                    break;
            }
           
        }
    }
}
