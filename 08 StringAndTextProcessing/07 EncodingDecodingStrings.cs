using System;
using System.Linq;
using System.Text;
//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR 
//(exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.

class EncodingDecodingStrings
{
    static void Main()
    {
        string text = "Write a program that encodes and decodes a string";
        string key = "dyrabyra";
        Console.WriteLine("Text For Encoding:");
        Console.WriteLine(text);

        string encodedText = Encode(text, key);
        Console.WriteLine("Encode:");
        Console.WriteLine(encodedText);
        Console.WriteLine();

        Console.WriteLine("Decode:");
        string decodedText = Decode(encodedText, key);
        Console.WriteLine(decodedText);
    }
    static string Encode(string text, string key)
    {
        char[] textArr = text.ToCharArray();
        char[] encodeSequence = new char[textArr.Length];
        StringBuilder sb = new StringBuilder();
        for (int i = 0, j = 0; i < encodeSequence.Length; j++, i++)
        {
            if (j == key.Length)
            {
                j = 0;
            }
            encodeSequence[i] = key[j];
        }

        for (int i = 0; i < textArr.Length; i++)
        {
            sb.Append((char)(textArr[i] ^ encodeSequence[i]));
        }
        return sb.ToString();
    }
    static string Decode(string text, string key)
    {
        return Encode(text,key).ToString();
    }
}

