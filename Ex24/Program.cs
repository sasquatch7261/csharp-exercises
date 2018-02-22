using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newID;

            Console.WriteLine("Enter your student ID's (or ENTER to finish):");
            do
            {
                Console.Write("ID: ");
                newID = int.Parse(Console.ReadLine());
                if (newID != 0)
                {
                    // Get the student's name
                    Console.WriteLine("name: ");
                    string newName = Console.ReadLine();

                    students.Add(newID, newName);
                }
            }
            while (newID != 0);

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

           

            Console.ReadLine();
        }
    }
}
