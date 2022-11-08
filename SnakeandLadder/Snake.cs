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
            int position2 = 0;
            int count1 = 0;
            int count2 = 0;

            Random random = new Random();

            while (position1 != 100 || position2 != 100)
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
                count1++;

                int MovingCheck1 = random.Next(1, 6);
                int StepCheck1 = random.Next(1, 3);
                Console.WriteLine($"Roll Die is : {MovingCheck1}");
                Console.WriteLine($"Moving Check is : {StepCheck1}");

                switch (StepCheck1)
                {
                    case Ahead_Move:

                        position2 = position2 + MovingCheck1;
                        Console.WriteLine("Ahead Move");

                        break;
                    case Behind_Move:

                        position2 = position2 - MovingCheck1;
                        Console.WriteLine("Behind Move");

                        break;
                    case No_Move:

                        position2 = position2 + MovingCheck1;
                        Console.WriteLine("No Move");

                        break;
                }
                if (position2 < 0)
                {
                    Console.WriteLine("Restart the Game");
                    position2 = 0;
                    continue;
                }
                if (position2 == 0)
                {
                    Console.WriteLine("Player 1st Wins the Game");
                    break;
                }
                count2++;
            }
            Console.WriteLine("Player 1st Dies: " + count1);
            Console.WriteLine("Player 2nd Dies: " + count2);

        }
    }
}

