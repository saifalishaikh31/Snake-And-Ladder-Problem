using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProblem
{
    class SnakeAndLaddeGame
    {
        const int NOPLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100, POSITION = 0;
        int player1_pos = 0, player2_pos = 0, count = 0;
        
        Random random = new Random();
        public int DiceRoll()
        {
            count++;
            return random.Next(1, 7);
        }



        public void Play()
        {
            while (this.player1_pos != WINNING_POSITION && this.player2_pos != WINNING_POSITION)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NOPLAY:
                        //Console.WriteLine("The player stays in the same position");
                        break;
                    case LADDER:
                        if (this.player1_pos + DiceRoll() < 100)
                        {
                            Console.WriteLine("player 1 position : " + this.player1_pos);
                            this.player1_pos += DiceRoll();
                            if (this.player1_pos + DiceRoll() < 100)
                            {
                                Console.WriteLine("player 1 play again");
                                this.player1_pos += DiceRoll();
                                Console.WriteLine("player 1 position : " + this.player1_pos);
                            }
                           
                        }
                        
                        if (this.player2_pos + DiceRoll() < 100)
                        {
                            Console.WriteLine("player 2 position : " + this.player2_pos);
                            this.player2_pos += DiceRoll();
                            if (this.player2_pos + DiceRoll() < 100)
                            {
                                Console.WriteLine("player 2 play again");
                                this.player2_pos += DiceRoll(); ;
                                Console.WriteLine("player 2 position : " + this.player2_pos);
                            }
                          
                        }
                        
                        break;

                    case SNAKE:

                        if (this.player1_pos + DiceRoll() >= 0)
                        {

                            this.player1_pos -= DiceRoll();
                            Console.WriteLine("player 1 position : " + this.player1_pos);

                        }
                        else
                        {
                            this.player1_pos = 0;
                            Console.WriteLine("player 1 position : " + this.player1_pos);
                        }

                        if (this.player2_pos + DiceRoll() >= 0)
                        {
                            this.player2_pos -= DiceRoll();
                            Console.WriteLine("player 2 position : " + this.player2_pos);
                        }
                        else
                        {
                            this.player2_pos = 0;
                            Console.WriteLine("player 2 position : " + this.player2_pos);
                        }
                        break;
                    default:
                        break;

                }

            } 
            Console.WriteLine("Number of time Dice Rolled" + count);
            if (player1_pos == WINNING_POSITION)
            {
                Console.WriteLine("Player1 Has Won The Game!!!");
            }
            else
            {
                Console.WriteLine("Player2 Has Won The Game!!!");
            }
        }
    }
}
