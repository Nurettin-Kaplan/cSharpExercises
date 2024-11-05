using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Factorial_Calculator_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result = 1;
            Console.WriteLine("Faktoriyel Hesaplama Uygulamasına Hoş Geldiniz!");
            Console.WriteLine();
            Console.Write("Sayıyı giriniz: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine("Cevap: " + result);

            Console.ReadLine();
        }
    }
}
