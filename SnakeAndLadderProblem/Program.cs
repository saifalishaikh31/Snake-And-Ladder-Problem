﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeAndLaddeGame game = new SnakeAndLaddeGame();
            game.Play();
            Console.ReadLine();
        }
    }
}
