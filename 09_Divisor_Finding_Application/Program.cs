using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Divisor_Finding_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Tam Bölenleri Bulma Uygulamasına Hoş Geldiniz!");
            Console.WriteLine();
            Console.Write("Sayıyı giriniz: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
