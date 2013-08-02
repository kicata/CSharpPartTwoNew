using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).


class HexToBinaryDirectly
{

    static void Main()
    {
        Console.Write("Enter Hex Number = ");
        string hexNumber = Console.ReadLine();
        char[] array = hexNumber.ToCharArray();
        string finalResult = "";
        for (int i = 0; i < array.Length; i++)
        {
            finalResult = finalResult + HexToBinaryInterpretator(array[i]);
        }
        Console.WriteLine("The binary representation of hex number {0} is {1}", hexNumber, finalResult);
    }
    public static string HexToBinaryInterpretator(char digit)
    {
        string hexInterpred = "";
        switch (digit)
        {
            case '0': hexInterpred = "0000"; break;
            case '1': hexInterpred = "0001"; break;
            case '2': hexInterpred = "0010"; break;
            case '3': hexInterpred = "0011"; break;
            case '4': hexInterpred = "0100"; break;
            case '5': hexInterpred = "0101"; break;
            case '6': hexInterpred = "0110"; break;
            case '7': hexInterpred = "0111"; break;
            case '8': hexInterpred = "1000"; break;
            case '9': hexInterpred = "1001"; break;
            case 'A': hexInterpred = "1010"; break;
            case 'B': hexInterpred = "1011"; break;
            case 'C': hexInterpred = "1100"; break;
            case 'D': hexInterpred = "1101"; break;
            case 'E': hexInterpred = "1110"; break;
            case 'F': hexInterpred = "1111"; break;
            default: Console.WriteLine("WTF !");
                break;
        }
        return hexInterpred;
    }
}
