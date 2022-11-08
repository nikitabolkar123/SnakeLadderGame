using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeandLadder
{
    internal class Snake
    {
        public const int Ahead_Move = 1;
        public const int Behind_Move = 2;
        public const int No_Move = 3;
        public void player()
        {
            int position1 = 0;
            int count = 0;

            Random random = new Random();
            while (position1 != 100)
            {
                int MovingCheck = random.Next(1, 6);
                int StepCheck = random.Next(1, 3);
                Console.WriteLine($"Roll Die is : {MovingCheck}");
                Console.WriteLine($"Moving Check is : {StepCheck}");

                switch (StepCheck)
                {
                    case Ahead_Move:

                        position1 = position1 + MovingCheck;
                        Console.WriteLine("Ahead Move");

                        break;
                    case Behind_Move:

                        position1 = position1 - MovingCheck;
                        Console.WriteLine("Behind Move");

                        break;
                    case No_Move:

                        position1 = position1 + MovingCheck;
                        Console.WriteLine("No Move");

                        break;
                }
                if (position1 < 0)
                {
                    Console.WriteLine("Restart the Game");
                    position1 = 0;
                    continue;
                }
                if (position1 == 0)
                {
                    Console.WriteLine("Player 1st Wins the Game");
                    break;
                }
                count++;
            }
            Console.WriteLine("Number Of Times Die Win :" + count);
        }
    }
}
