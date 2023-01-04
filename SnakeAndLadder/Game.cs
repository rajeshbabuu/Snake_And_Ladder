﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
 
{
    public class Game
    {
        public void player1()
        {
             public const int FORWARD_MOVE = 1;
        public const int BACKWARD_MOVE = 2;
        public const int NO_MOVE = 3;

        public void snakeAndLadder()
        {
            int position = 0;

            Random random = new Random();
           
            int movingCheck = random.Next(1, 3);
            int stepCheck = random.Next(1, 6);
            Console.WriteLine("this is moving check " + movingCheck);
            Console.WriteLine("this is step check " + stepCheck);

            switch (movingCheck)
            {
                case FORWARD_MOVE:
                    if (position < 100)
                    {
                        position = position + stepCheck;
                        Console.WriteLine("Forward move");
                    }
                    break;
                case BACKWARD_MOVE:
                    if (position > 0)
                    {
                        position = position - stepCheck;
                        Console.WriteLine("Backward move");
                    }
                    break;
                case NO_MOVE:
                    position = position + stepCheck;
                    Console.WriteLine("No move");

                    break;
            }
            Console.WriteLine(position + " step count ");


        }
        }

           

    }
}
