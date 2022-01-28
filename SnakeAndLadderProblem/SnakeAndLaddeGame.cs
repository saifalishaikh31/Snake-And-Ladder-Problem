using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProblem
{
    class SnakeAndLaddeGame
    {
        int player_pos = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            return random.Next(1, 7);  
            
        }
    }
}
