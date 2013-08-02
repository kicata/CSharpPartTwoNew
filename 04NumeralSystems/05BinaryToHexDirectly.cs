using System;
//Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHexDirectly
{
    static void Main()
        {
            Console.Write("Enter Binary Number = ");
            string binaryNumber = Console.ReadLine();
            char[] array = binaryNumber.ToCharArray();
            int counter = 0;
            string finalResult = "";
            string fourBit ="";
            for (int i = 0; i < array.Length; i++)
            {
                fourBit=fourBit+array[i].ToString();
                counter++;
                if (counter == 4)
                {
                    finalResult = finalResult + BinaryToHexInterpretator(fourBit);
                    fourBit = "";
                    counter = 0;
                }
            }

            Console.WriteLine("The hex representation of binary number {0} is {1}",binaryNumber,finalResult);
        }
    public static string BinaryToHexInterpretator(string fourBit)
    {
        string hexInterpred = "";
        switch (fourBit)
        {
            case "0000": hexInterpred = "0"; break;
            case "0001": hexInterpred = "1"; break;
            case "0010": hexInterpred = "2"; break;
            case "0011": hexInterpred = "3"; break;
            case "0100": hexInterpred = "4"; break;
            case "0101": hexInterpred = "5"; break;
            case "0110": hexInterpred = "6"; break;
            case "0111": hexInterpred = "7"; break;
            case "1000": hexInterpred = "8"; break;
            case "1001": hexInterpred = "9"; break;
            case "1010": hexInterpred = "A"; break;
            case "1011": hexInterpred = "B"; break;
            case "1100": hexInterpred = "C"; break;
            case "1101": hexInterpred = "D"; break;
            case "1110": hexInterpred = "E"; break;
            case "1111": hexInterpred = "F"; break;
            default: Console.WriteLine("WTF !");
                break;
        }
        return hexInterpred;
    }
}

