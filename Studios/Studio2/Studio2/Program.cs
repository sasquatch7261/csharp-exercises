using System;
using System.Collections.Generic;

namespace Studio2
{
    class Program
    {
        static void Main(string[] args)

        {
            int sum = 0;
           
            List<int> ListOfInts = new List<int>();
            Dictionary<char, int> LetterCount = new Dictionary<char, int>();
            string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            List<char> ListOfChars = new List<char>(sentence.Substring(0));

            foreach (char letter in sentence)
            {
                foreach (char let in ListOfChars)
                {
                    if (let == letter)
                    {
                        break;
                    }
                    else
                    {
                        ListOfChars.Add(letter);
                    }
                }
            
            }
            foreach (char letter in sentence)
            {
                foreach (char let in ListOfChars)
                {
                    if (let == letter)
                    {
                        break;
                    }
                    else
                    {
                        sum = sum + 1;
                    }  
                }
                ListOfInts.Add(sum);
            }
            
            for (int i = 0; i < ListOfChars.Count; i++)
            {
                LetterCount.Add(ListOfChars[i], ListOfInts[i]);
            }

            foreach (KeyValuePair<char, int> pair in LetterCount)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            Console.ReadLine();

            Console.WriteLine(ListOfChars.Count);
            Console.ReadLine();
        }
    }
}
