using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Season_Month_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season;
            Console.WriteLine("Mevsim-Ay Uygulamasına Hoş Geldiniz!");
            Console.WriteLine();
            Console.Write("Bir mevsim adı giriniz(İlkbahar - Yaz - Sonbahar - Kış): ");
            season = Console.ReadLine();

            switch (season)
            {
                case "İlkbahar":Console.WriteLine("Mart -  Nisan - Mayıs"); break;
                case "Yaz": Console.WriteLine("Haziran - Temmuz - Ağustos"); break;
                case "Sonbahar": Console.WriteLine("Eylül - Ekim - Kasım"); break;
                case "Kış": Console.WriteLine("Aralık - Ocak - Şubat"); break;
                default: Console.WriteLine("Hatalı mevsim adı girdiniz."); break;
            }

            Console.Read();
        }
    }
}
