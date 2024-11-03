using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace _04_Finding_Rectangle_Area_And_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write the code to calculate the area and perimeter of a rectangle with its length and width entered in the code section.

            int width, length, area, perimeter;
            width = 15;
            length = 7;

            area = width * length;
            perimeter = 2 * (area + length);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            Console.Read();
        }
    }
}
