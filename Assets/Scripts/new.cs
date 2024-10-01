using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        int thrust = 0;
        bool boost = true;

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int nextCheckpointX = int.Parse(inputs[2]); // x position of the next check point
            int nextCheckpointY = int.Parse(inputs[3]); // y position of the next check point
            int nextCheckpointDist = int.Parse(inputs[4]); // distance to the next checkpoint
            int nextCheckpointAngle = int.Parse(inputs[5]); // angle between your pod orientation and the direction of the next checkpoint
            inputs = Console.ReadLine().Split(' ');
            int opponentX = int.Parse(inputs[0]);
            int opponentY = int.Parse(inputs[1]);


            double angle = Math.PI * nextCheckpointAngle / 180.0; //conversion degrés en radiants

            if (nextCheckpointDist >=500)
            {
                thrust = (int) (Math.Abs(Math.Cos(angle)*100) * 2);
                if (thrust > 100)
                {
                    thrust = 100;
                }
            }

            else if (nextCheckpointDist <=500)
            {
                thrust = 50;
            }

            else if (nextCheckpointDist <=300)
            {
                thrust = 20;
                nextCheckpointAngle = 0;
            }

            //déviations pour éviter collisions
            if(x - opponentX <= 460)
            {
                nextCheckpointAngle -=90;
            }
            else if (opponentX - x <=460)
            {
                nextCheckpointAngle +=90;
            }

            if(y - opponentY <= 460)
            {
                nextCheckpointAngle -=90;
            }
            else if (opponentY - y <=460)
            {
                nextCheckpointAngle +=90;
            }

            //couper moteurs si collision s'est produite
            //si avatar dans aura 400x400, thrust = 0
            //COMMENT REMETTRE EN ROUTE ?
            // if(x - opponentX <= 400)
            // {
            //     thrust = 0;
            // }
            // else if (opponentX - x <=400)
            // {
            //     thrust = 0;
            // }

            //faire demi-tour plus vite
            if (nextCheckpointAngle > 90 || nextCheckpointAngle < -90)
            {
                nextCheckpointAngle = -nextCheckpointAngle;
            }

            if (nextCheckpointDist >= 2500 && boost == true && nextCheckpointAngle <= 60)
            {
                Console.WriteLine(nextCheckpointX + " " + nextCheckpointY + " " + "BOOST");
                boost = false;

            }
            else
            {
                Console.WriteLine(nextCheckpointX + " " + nextCheckpointY + " " + thrust);
            }

            // Write an action using Console.WriteLine()
            //Console.Error.WriteLine("Debug messages...");


            // You have to output the target position
            // followed by the power (0 <= thrust <= 100)
            // i.e.: "x y thrust"
            
        }
    }
}