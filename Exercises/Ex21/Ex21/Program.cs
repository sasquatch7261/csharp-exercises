using System;
using System.Collections.Generic;


namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "five", "four", "six", "apple", "dogs" };
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                        Console.ReadLine();


                }
            }
        }
    }
}
