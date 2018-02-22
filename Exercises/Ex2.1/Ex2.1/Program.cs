using System;
using System.Collections.Generic;

namespace Ex2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int sum = AddEvens(numbers);
            string total = sum.ToString();
            Console.WriteLine(total);
            Console.ReadLine();
            
        }

        static int AddEvens(List<int> numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;

        }
    }
}


