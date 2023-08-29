using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ortalama;


            Console.WriteLine("Lütfen Birinci Notunuzu Giriniz :");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen İkinci Notunuzu Giriniz :");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Final Notunuzu Giriniz :");
            int not3 = Convert.ToInt32(Console.ReadLine());
            
            ortalama = ((not1 * 40) / 100) + ((not2 * 40) / 100) + ((not3 * 60) / 100) / 3;

            if (ortalama < 40)
            {
                Console.WriteLine("F");
            }
            else if (ortalama <= 60 && ortalama >= 40)
            {
                Console.WriteLine("B+");
            }
            else if (ortalama > 60 && ortalama < 80)
            {
                Console.WriteLine("A");
            }
            else if (ortalama >= 80 && ortalama <= 100)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Geçersiz Not Girdiniz");
            }

        }
    }
}
