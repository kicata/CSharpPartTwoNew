using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Slides
{
    class Ball
    {
        
        public int BallWidth { get; set; }

        public int BallHeight { get; set; }

        public int BallDepth { get; set; }

        public Ball(Ball ball)
        {
            this.BallWidth = ball.BallWidth;
            this.BallHeight = ball.BallHeight;
            this.BallDepth = ball.BallDepth;
        }

        public Ball(int ballWidth, int ballHeight, int ballDepth)
        {
            this.BallWidth = ballWidth;
            this.BallHeight = ballHeight;
            this.BallDepth = ballDepth;
        }
    }

    class Slides
    {
        private static int width, depth, height;
        private static string[, ,] cube;
        private static Ball cubeBall;

        static void Main()
        {
            ReadInput();
            ProcessBallCommands();
        }

        private static void ProcessBallCommands()
        {
            while (true)
            {
                string currCell =
                cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];
                string[] splittedCell = currCell.Split();
                string command = splittedCell[0];
                switch (command)
                {
                    case "S":
                        ProcessBallSlides(splittedCell[1]);
                        break;
                    case "T":
                        cubeBall.BallWidth = int.Parse(splittedCell[1]);
                        cubeBall.BallDepth = int.Parse(splittedCell[2]);
                        break;
                    case "B":
                        PrintMessage();
                        return;
                    case "E":
                        if (cubeBall.BallHeight == height - 1)//dali e na posleden red
                        {
                            PrintMessage();
                            return;
                        }
                        else
                        {
                            cubeBall.BallHeight++;
                        }
                        break;
                    default: throw new ArgumentException("Invalid command");
                        
                }
            }
        }

        private static void ProcessBallSlides(string command)
        {
            Ball newCubeBall = new Ball(cubeBall);//make a new ball at position

            switch (command)
            {
                case "R":
                    newCubeBall.BallHeight++;
                    newCubeBall.BallWidth++;
                    break;
                case "L":
                    newCubeBall.BallWidth--;
                    newCubeBall.BallHeight++;
                    break;
                case "F":
                    newCubeBall.BallDepth--;
                    newCubeBall.BallHeight++;
                    break;
                case "B":
                    newCubeBall.BallDepth++;
                    newCubeBall.BallHeight++;
                    break;
                case "FL":
                    newCubeBall.BallDepth--;
                    newCubeBall.BallWidth--;
                    newCubeBall.BallHeight++;
                    break;
                case "FR":
                    newCubeBall.BallDepth--;
                    newCubeBall.BallWidth++;
                    newCubeBall.BallHeight++;
                    break;
                case "BL":
                    newCubeBall.BallDepth++;
                    newCubeBall.BallWidth--;
                    newCubeBall.BallHeight++;
                    break;
                case "BR":
                    newCubeBall.BallDepth++;
                    newCubeBall.BallWidth++;
                    newCubeBall.BallHeight++;
                    break;
                default:
                    throw new ArgumentException("Ivalid slide command");
            }

            if (IsPassable(newCubeBall))
            {
                cubeBall = new Ball(newCubeBall);
            }
            else
            {

                PrintMessage();
                Environment.Exit(0);//stop all program
            }
        }

        private static void PrintMessage()
        {
            string currentCell=cube[cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth];
            if (currentCell=="B" || cubeBall.BallHeight!=height-1)
            {
               Console.WriteLine("No"); 
            }
            else
            {
                Console.WriteLine("Yes"); 
            }
            Console.WriteLine("{0} {1} {2}",
            cubeBall.BallWidth, cubeBall.BallHeight, cubeBall.BallDepth);
        }

        private static bool IsPassable(Ball newCubeBall)
        {
            if (newCubeBall.BallWidth>=0 &&
                newCubeBall.BallHeight>=0 &&
                newCubeBall.BallDepth>=0 &&
                 newCubeBall.BallWidth<width &&
                 newCubeBall.BallHeight< height&&
                 newCubeBall.BallHeight< depth
                )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        private static void ReadInput()
        {
            string[] rawNumbers = Console.ReadLine().Split(' ');
            width = int.Parse(rawNumbers[0]);
            height = int.Parse(rawNumbers[1]);
            depth = int.Parse(rawNumbers[2]);
            cube = new string[width, height, depth];
            //fill in cube
            for (int h = 0; h < height; h++)
            {
                string[] lineFragment = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);//reading every line
                for (int d = 0; d < depth; d++)
                {
                    string[] cubeContent = lineFragment[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }
            }
           //initial coordinate of the ball
            string[] rawBallCoords = Console.ReadLine().Split();

            int ballWidth = int.Parse(rawBallCoords[0]);
            int ballDepth = int.Parse(rawBallCoords[1]);

            cubeBall = new Ball(ballWidth, 0, ballDepth);
        }
    }
}
