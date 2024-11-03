using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string city, district;
            city = "İstanbul";
            district = "Üsküdar";
            Console.Write(city + "-" + district);

            Console.Read();
            */

            //int num;
            //num = 24;
            //Console.Write(num);

            /*
            int num1, num2, sum = 0;
            num1 = 12;
            num2 = 25;
            sum = num1 + num2;
            Console.Write(sum);
            */

            /*
            int num1, num2, sum, mul, div, sub;
            
            Console.WriteLine("***** Arithmetic Operations *****");
            Console.WriteLine();
            num1 = 20;
            num2 = 3;
            sum = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);
            Console.WriteLine("Division: " + div);
            Console.WriteLine();
            Console.WriteLine("***** Arithmetic Operations *****");

            */

            //double number;
            //number = 24.9;
            //Console.WriteLine(number);

            /*
            double ex1, ex2, avg;
            ex1 = 78;
            ex2 = 85;
            avg = (ex1 + ex2) / 2;
            Console.WriteLine(avg);
            */

            string city, district;
            Console.Write("Lütfen şehrinizi girin: ");
            city = Console.ReadLine();
            Console.Write("Lütfen ilçeyi girin: ");
            district = Console.ReadLine();
            Console.WriteLine("Girdiğiniz şehir ve ilçe: " + city + "-" + district);

            Console.Read();
        }
    }
}
