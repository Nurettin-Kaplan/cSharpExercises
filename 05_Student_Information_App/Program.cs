using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Student_Information_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, department, lesson;
            int ex1, ex2, ex3, avg;

            name = "Nurettin";
            surname = "Kaplan";
            department = "Software Engineering";
            lesson = "Algorithm Programming";

            ex1 = 65;
            ex2 = 70;
            ex3 = 88;
            avg = (ex1 + ex2 + ex3) / 3;

            Console.WriteLine("***** Student Information System *****");
            Console.WriteLine();
            Console.WriteLine("Student's Name Surname: " + name + " " + surname);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Lesson: " + lesson);
            Console.WriteLine();
            Console.WriteLine("Exam 1: " + ex1);
            Console.WriteLine("Exam 2: " + ex2);
            Console.WriteLine("Exam 3: " + ex3);
            Console.WriteLine("Average: " + avg);

            Console.Read();

        }
    }
}
