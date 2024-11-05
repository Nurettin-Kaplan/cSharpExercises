using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Plate_City_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte plateNum;
            Console.Write("Plakayı giriniz: ");
            plateNum = Convert.ToByte(Console.ReadLine());

            switch (plateNum)
            {
                case 01: Console.WriteLine("Merhaba Adana"); break;
                case 02: Console.WriteLine("Merhaba Adıyaman"); break;
                case 03: Console.WriteLine("Merhaba Afyon"); break;
                case 04: Console.WriteLine("Merhaba Ağrı"); break;
                case 05: Console.WriteLine("Merhaba Amasya"); break;
                case 06: Console.WriteLine("Merhaba Ankara"); break;
                case 07: Console.WriteLine("Merhaba Antalya"); break;
                case 08: Console.WriteLine("Merhaba Artvin"); break;
                case 09: Console.WriteLine("Merhaba Aydın"); break;
                case 10: Console.WriteLine("Merhaba Balıkesir"); break;
                case 11: Console.WriteLine("Merhaba Bilecik"); break;
                case 12: Console.WriteLine("Merhaba Bingöl"); break;
                case 13: Console.WriteLine("Merhaba Bitlis"); break;
                case 14: Console.WriteLine("Merhaba Bolu"); break;
                case 15: Console.WriteLine("Merhaba Burdur"); break;
                case 16: Console.WriteLine("Merhaba Bursa"); break;
                case 17: Console.WriteLine("Merhaba Çanakkale"); break;
                case 18: Console.WriteLine("Merhaba Çankırı"); break;
                case 19: Console.WriteLine("Merhaba Çorum"); break;
                case 20: Console.WriteLine("Merhaba Denizli"); break;
                case 21: Console.WriteLine("Merhaba Diyarbakır"); break;
                case 22: Console.WriteLine("Merhaba Edirne"); break;
                case 23: Console.WriteLine("Merhaba Elazığ"); break;
                case 24: Console.WriteLine("Merhaba Erzincan"); break;
                case 25: Console.WriteLine("Merhaba Erzurum"); break;
                case 26: Console.WriteLine("Merhaba Eskişehir"); break;
                case 27: Console.WriteLine("Merhaba Gaziantep"); break;
                case 28: Console.WriteLine("Merhaba Giresun"); break;
                case 29: Console.WriteLine("Merhaba Gümüşhane"); break;
                case 30: Console.WriteLine("Merhaba Hakkari"); break;
                case 31: Console.WriteLine("Merhaba Hatay"); break;
                case 32: Console.WriteLine("Merhaba Isparta"); break;
                case 33: Console.WriteLine("Merhaba Mersin"); break;
                case 34: Console.WriteLine("Merhaba İstanbul"); break;
                case 35: Console.WriteLine("Merhaba İzmir"); break;
                case 36: Console.WriteLine("Merhaba Kars"); break;
                case 37: Console.WriteLine("Merhaba Kastamonu"); break;
                case 38: Console.WriteLine("Merhaba Kayseri"); break;
                case 39: Console.WriteLine("Merhaba Kırklareli"); break;
                case 40: Console.WriteLine("Merhaba Kırşehir"); break;
                case 41: Console.WriteLine("Merhaba Kocaeli"); break;
                case 42: Console.WriteLine("Merhaba Konya"); break;
                case 43: Console.WriteLine("Merhaba Kütahya"); break;
                case 44: Console.WriteLine("Merhaba Malatya"); break;
                case 45: Console.WriteLine("Merhaba Manisa"); break;
                case 46: Console.WriteLine("Merhaba Kahramanmaraş"); break;
                case 47: Console.WriteLine("Merhaba Mardin"); break;
                case 48: Console.WriteLine("Merhaba Muğla"); break;
                case 49: Console.WriteLine("Merhaba Muş"); break;
                case 50: Console.WriteLine("Merhaba Nevşehir"); break;
                case 51: Console.WriteLine("Merhaba Niğde"); break;
                case 52: Console.WriteLine("Merhaba Ordu"); break;
                case 53: Console.WriteLine("Merhaba Rize"); break;
                case 54: Console.WriteLine("Merhaba Sakarya"); break;
                case 55: Console.WriteLine("Merhaba Samsun"); break;
                case 56: Console.WriteLine("Merhaba Siirt"); break;
                case 57: Console.WriteLine("Merhaba Sinop"); break;
                case 58: Console.WriteLine("Merhaba Sivas"); break;
                case 59: Console.WriteLine("Merhaba Tekirdağ"); break;
                case 60: Console.WriteLine("Merhaba Tokat"); break;
                case 61: Console.WriteLine("Merhaba Trabzon"); break;
                case 62: Console.WriteLine("Merhaba Tunceli"); break;
                case 63: Console.WriteLine("Merhaba Şanlıurfa"); break;
                case 64: Console.WriteLine("Merhaba Uşak"); break;
                case 65: Console.WriteLine("Merhaba Van"); break;
                case 66: Console.WriteLine("Merhaba Yozgat"); break;
                case 67: Console.WriteLine("Merhaba Zonguldak"); break;
                case 68: Console.WriteLine("Merhaba Aksaray"); break;
                case 69: Console.WriteLine("Merhaba Bayburt"); break;
                case 70: Console.WriteLine("Merhaba Karaman"); break;
                case 71: Console.WriteLine("Merhaba Kırıkkale"); break;
                case 72: Console.WriteLine("Merhaba Batman"); break;
                case 73: Console.WriteLine("Merhaba Şırnak"); break;
                case 74: Console.WriteLine("Merhaba Bartın"); break;
                case 75: Console.WriteLine("Merhaba Ardahan"); break;
                case 76: Console.WriteLine("Merhaba Iğdır"); break;
                case 77: Console.WriteLine("Merhaba Yalova"); break;
                case 78: Console.WriteLine("Merhaba Karabük"); break;
                case 79: Console.WriteLine("Merhaba Kilis"); break;
                case 80: Console.WriteLine("Merhaba Osmaniye"); break;
                case 81: Console.WriteLine("Merhaba Düzce"); break;
                default:
                    Console.WriteLine("Yazılan numarada bir şehir bulunamamıştır.");
                    break;
            }

            Console.Read();
        }
    }
}
