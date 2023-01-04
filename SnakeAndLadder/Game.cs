using System;
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
            int Player1 = 1;
            int Position1 = 0;
        }
        public void firstDiceRoll()
        {
            Console.WriteLine("First Dice Roll " );
            Random random = new Random();
            Console.WriteLine(random.Next(1,6));
        }

           

    }
}
