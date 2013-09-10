using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class GenomeDecoder
    {

        static void Main()
        {
            ReadInput();
        }
        static void ReadInput()
        {
            string[]input=Console.ReadLine().Split(' ');
            int letterPerLine=int.Parse(input[0]);
            int spaceOnEvery=int.Parse(input[1]);
            string encodedSeq = Console.ReadLine();
            StringBuilder decodeGenom = DecodeGenom(encodedSeq);
            //Console.WriteLine(decodeGenom.ToString());
            PrintFormattedOutput(decodeGenom, letterPerLine, spaceOnEvery);

        }
        static void PrintFormattedOutput(StringBuilder decodeGenom, int letterPerLine, int spaceOnEvery)
        {
            int outputLines = (int)Math.Ceiling((double)decodeGenom.Length / (double)letterPerLine);
            int maxLineNumberDigits = outputLines.ToString().Length;//kolko e nai goliamoto 4islo kato broi simvoli
            StringBuilder currentFormattedLine = new StringBuilder();
            int currentIndexInDecodedGenome = 0;
            for (int line = 1; line <=outputLines; line++)
            {
                string leadingIntervals = new string(' ', maxLineNumberDigits - line.ToString().Length);
                currentFormattedLine.Append(leadingIntervals);
                currentFormattedLine.Append(line);

                currentIndexInDecodedGenome = (line - 1) * letterPerLine;

                for (int i = currentIndexInDecodedGenome; i < line * letterPerLine; i++)
                {
                    if (Math.Abs((currentIndexInDecodedGenome-i) % spaceOnEvery)==0)
                    {
                        currentFormattedLine.Append(' ');
                    }
                    if (i>=decodeGenom.Length)
                    {
                        break;
                    }
                    currentFormattedLine.Append(decodeGenom[i]);
                }
                Console.WriteLine(currentFormattedLine);
                currentFormattedLine.Clear();
            }
        }

        static StringBuilder DecodeGenom(string input)
        {
            StringBuilder decodeGenom = new StringBuilder();//output
            StringBuilder repeatTimesString = new StringBuilder();

            foreach (char symbol in input)
            {
                if (symbol=='A'||symbol=='C'||symbol=='G'||symbol=='T')
                {
                    int repeatTimes = 1;
                    if (repeatTimesString.Length!=0)
                    {
                        repeatTimes = int.Parse(repeatTimesString.ToString());
                        repeatTimesString.Clear();
                    }
                    string genomeSubSeq = new string(symbol, repeatTimes);
                    decodeGenom.Append(genomeSubSeq);
                }
                else
                {
                    repeatTimesString.Append(symbol);
                }
            }
            return decodeGenom;
        }
    }

