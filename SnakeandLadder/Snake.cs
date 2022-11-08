using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeandLadder
{
    internal class Snake
    {
        public void player()
        {
            Random random = new Random();
            int Die = random.Next(1, 6);
            Console.WriteLine($"Roll Die is : {Die}");
        }
    }
}
