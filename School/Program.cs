using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John");
            Console.WriteLine(john);
            Console.ReadLine();

            john.AddGrade(3, 4.0);
            Console.WriteLine(john);
            Console.ReadLine();
        }
    }

    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double currentQualityScore = Gpa * NumberOfCredits;
            double qualityScore = courseCredits * grade;
            double newQualityScore = currentQualityScore + qualityScore;

            NumberOfCredits = NumberOfCredits + courseCredits;
            Gpa = newQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits >= 0 && NumberOfCredits <= 29)
            {
                return "freshman";
            }
            else if (NumberOfCredits >= 30 && NumberOfCredits <= 59)
            {
                return "sophomore";
            }
            else if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
            {
                return "junior";
            }
            else
            {
                return "senior";
            }
        }

        public override String ToString()
        {
            return Name + " (Number of credits: " + NumberOfCredits + ", Gpa: " + Gpa + ")";
        }

        public bool Equals(Object o)
        {
            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }

    }

    public class Course
    {
        private Dictionary<string, int> Name { get; set; }
        public int CreditHours { get; set; }
        public string Teacher { get; set; }
    }
}
