using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _11_Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Not Sistemine Hoş Geldiniz!");
            Console.WriteLine();
            Console.Write("Öğrenci sayısını giriniz: ");

            int size1, size2 = 0;
            size1 = Convert.ToInt32(Console.ReadLine());
            double sum = 0, avg = 0; 

            string[] students = new string[size1];
            double[] notes = new double[size1];

            for (int i = 0; i < size1; i++)
            {
                Console.Write("Öğrenci ismini ve soyismini aralarına boşluk koyarak giriniz: ");
                students[i] = Console.ReadLine();

                Console.Write("Öğrenci notunu giriniz: ");
                notes[i] = Convert.ToDouble(Console.ReadLine());
                sum += notes[i];

                if (notes[i] <= 49)
                {
                    size2++;
                }
            }

            avg = sum / size1;

            double[] badNotes = new double[size2];
            string[] badStudents = new string[size2];

            for (int j = 0;  j < size1; j++)
            {
                int k = 0;
                if (notes[j] <= 49)
                {
                    badStudents[k] = students[j];
                    badNotes[k] = notes[j];
                    k++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Dersten kalan öğrenciler: ");

            for(int z = 0; z < size2; z++)
            {
                Console.WriteLine("Öğrenci ismi: " + badStudents[z] + " Notu: " + badNotes[z]);
            }

            Console.WriteLine();
            Console.WriteLine("En yüksek not alan öğrenci: " + students[Array.IndexOf(notes, notes.Max())] + " Notu: " + notes.Max());
            Console.WriteLine("En düşük not alan öğrenci: " + students[Array.IndexOf(notes, notes.Min())] + " Notu: " + notes.Min());
            Console.WriteLine("Sınıfın not oralaması: " + avg);

            Console.Read();
        }
    }
}
