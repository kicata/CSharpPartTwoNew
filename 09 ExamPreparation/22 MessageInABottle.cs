using System;
using System.Collections.Generic;
using System.Text;
class State
{
    public string Received { get; set; }
    public string Left { get; set; }
}
class CipherElement
{
    public char Letter { get; set; }
    public string Digits { get; set; }
}

    class MessageInABottle

    {
        static void Main()
        {
            string code = Console.ReadLine();
            string cipherToDecode = Console.ReadLine();

            List<CipherElement> cipher = BuildCipher(cipherToDecode);

            List<State> states = new List<State>();
            List<string> results = new List<string>();
            states.Add(new State() {Received = "", Left = code });
            int index=0;
            while (index<states.Count)
            {
                State currentState = states[index];

                index++;
                foreach (var cipherElement in cipher)
                {
                    if (currentState.Left.StartsWith(cipherElement.Digits))
                    {
                        State newState = new State();
                        newState.Received = currentState.Received + cipherElement.Letter;
                        newState.Left = currentState.Left.Remove(0, cipherElement.Digits.Length);
                        if (newState.Left=="")
                        {
                            results.Add(newState.Received);
                        }
                        else
                        {
                            states.Add(newState);
                        }
                    }
                }
            }
            Console.WriteLine(results.Count);
            results.Sort();
            foreach (var decodedLetters in results)
            {
                Console.WriteLine(decodedLetters);
                
            }
        }
       
        private static List<CipherElement> BuildCipher(string cipherToDecode )
        {
            List<CipherElement> elements=new List<CipherElement>();
            char? letter = null;
            StringBuilder digits = new StringBuilder();
            //cipherToDecode += 'Z';
            foreach (var currentChar in cipherToDecode)
            {
                if (char.IsLetter(currentChar))
                {
                    if (letter != null)
                    {
                        CipherElement newElement = new CipherElement();
                        newElement.Letter = letter.Value;
                        newElement.Digits = digits.ToString();
                        elements.Add(newElement);
                        digits.Clear();

                    }
                    letter = currentChar;
                }
                else
                {
                    //append digits
                    digits.Append(currentChar);
                }
            }

            CipherElement lastElement = new CipherElement();
            lastElement.Letter = letter.Value;
            lastElement.Digits = digits.ToString();
            elements.Add(lastElement);
            digits.Clear();

            return elements;
        }

    }

