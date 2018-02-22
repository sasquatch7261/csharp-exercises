using System;

namespace Ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6]{1,1,2,3,5,8};

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                
            }
            Console.ReadLine();
        }
    }
}
