using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Quiz_Competition_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int question = 1, score = 0;
            char answer;

            Console.WriteLine("Welcome To The Quiz Competition!");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            if (question == 1)
            {
                Console.WriteLine("1- What is the capital of Turkey?");
                Console.WriteLine("A)Istanbul\nB)Ankara\nC)İzmir\nD)Antalya");
                Console.Write("Enter your answer: ");
                answer = Convert.ToChar(Console.ReadLine());

                if(answer == 'b' || answer  == 'B')
                {
                    question += 1;
                    score += 10;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Your score: " + score);
                }
            }

            if (question == 2)
            {
                Console.WriteLine("1- When was the Republic of Turkey founded?");
                Console.WriteLine("A)1920\nB)1921\nC)1922\nD)1923");
                Console.Write("Enter your answer: ");
                answer = Convert.ToChar(Console.ReadLine());

                if (answer == 'd' || answer == 'D')
                {
                    question += 1;
                    score += 10;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Your score: " + score);
                }
            }

            if (question == 3)
            {
                Console.WriteLine("What is the birth date of Mustafa Kemal Atatürk?");
                Console.WriteLine("A)1880\nB)1881\nC)1882\nD)1883");
                Console.Write("Enter your answer: ");
                answer = Convert.ToChar(Console.ReadLine());

                if (answer == 'b' || answer == 'B')
                {
                    question += 1;
                    score += 10;
                    Console.WriteLine("You have completed the quiz. Your score: " + score);
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect. Your score: " + score);
                }
            }

            Console.Read();
        }
    }
}
