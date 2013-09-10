using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Stars3D
{
    private static int width, height, depth, starCount;
    private static char[, ,] cube;
    private static Dictionary<char, int> starType = new Dictionary<char, int>();
    static void Main()
    {
        ReadInput();
        FindStars();
        PrintMessage();
    }
    private static void ReadInput()
    {
        string[] rawNumbers = Console.ReadLine().Split();
        width = int.Parse(rawNumbers[0]);
        height = int.Parse(rawNumbers[1]);
        depth = int.Parse(rawNumbers[2]);
        cube = new char[width, height, depth];
        for (int h = 0; h < height; h++)
        {
            string[] line = Console.ReadLine().Split();
            for (int d = 0; d < depth; d++)
            {
                string part = line[d];

                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = part[w];
                }
            }
        }
    }
    private static void FindStars()
    {
        for (int w = 1; w < width - 1; w++)//because we looking for a star
        {
            for (int h = 1; h < height - 1; h++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    FindSingleStar(w, h, d);
                }
            }

        }
    }
    private static void FindSingleStar(int currWidth, int currHeight, int currDepth)
    {
        char currChar = cube[currWidth, currHeight, currDepth];
        bool isStar =
            currChar == cube[currWidth - 1, currHeight, currDepth] &&
            currChar == cube[currWidth + 1, currHeight, currDepth] &&
            currChar == cube[currWidth, currHeight - 1, currDepth] &&
            currChar == cube[currWidth, currHeight + 1, currDepth] &&
            currChar == cube[currWidth, currHeight, currDepth - 1] &&
            currChar == cube[currWidth, currHeight, currDepth + 1];
        if (isStar)
        {
            starCount++;
            if (starType.ContainsKey(currChar))
            {
                starType[currChar]++;
            }
            else
            {
                starType.Add(currChar,1);
            }
        }
    }
    private static void PrintMessage()
    {
        //Sort the dictionary
        starType.OrderBy(x=>x.Key); //lambda izraz

        Console.WriteLine(starCount);
        foreach (var star in starType)
        {
            Console.WriteLine("{0} {1}", star.Key, star.Value); 
        }
    }







}
