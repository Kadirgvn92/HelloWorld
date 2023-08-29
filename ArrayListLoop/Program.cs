using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int even= 0, odd=0, number1 = 0;
            int evensum = 0, oddsum= 0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write(i + ". numarayı giriniz : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even++;
                    Console.WriteLine((i + 1) + ". sayı = " + numbers[i] + " çift sayıdır.");
                    evensum = numbers[i] + evensum;
                }
                else if(numbers[i] % 2  != 0)
                {
                    odd++;
                    Console.WriteLine((i + 1) + ". sayı = " + numbers[i] + " tek sayıdır.");
                    oddsum = numbers[i] + oddsum;
                } else
                {
                    Console.WriteLine("---------------------------");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.WriteLine(even + " adet çift sayı vardır.");
            Console.WriteLine(odd + " adet tek sayı vardır.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.WriteLine("Çift sayıların toplamı = " + evensum);
            Console.WriteLine("Tek sayıların toplamı = " +  oddsum);


            if (evensum > oddsum)
            {
                Console.WriteLine("Çift Değerlerin Toplamı Büyüktür.");
            }else if (oddsum > evensum)
            {
                Console.WriteLine("Tek Değerlerin Toplamı Büyüktür.");
            }
            else
            {
                Console.WriteLine("Tek Değerlerin Toplamı ile Çift Değerlerin Toplamı eşittir.");
            }
        }
    }
}
