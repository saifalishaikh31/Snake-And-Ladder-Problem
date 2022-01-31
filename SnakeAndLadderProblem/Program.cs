using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WINNING_POSITION = 100;
            
            SnakeAndLaddeGame player1 = new SnakeAndLaddeGame();
            SnakeAndLaddeGame player2 = new SnakeAndLaddeGame();
            Random random = new Random();
            int option = random.Next(0, 2);
            bool turn = true;
            if (option == 0)
                turn = true;
            if (option == 1)
                turn = false;
            int player1Position = 0, player2Position = 0;
            bool flag = true;
            while (flag)
            {
                if (turn)
                {
                    player1Position = player1.Play();
                    turn = false;
                    Console.WriteLine("Player1 Position : " + player1Position);
                }
                else
                {
                    player2Position = player2.Play();
                    turn = true;
                    Console.WriteLine("Player2 Position : " + player2Position);
                }
                

                if (player1Position == WINNING_POSITION)
                {
                    Console.WriteLine("Player1 won the game! \n");
                    flag = false;
                }
                if (player2Position == WINNING_POSITION)
                {
                    Console.WriteLine("Player2 won the game! \n");
                    flag = false;
                }
            
            }
            
            Console.ReadLine();
        }
    }
}
