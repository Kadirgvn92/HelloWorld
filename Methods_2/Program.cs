using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı giriniz : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            max(num1, num2);

        }

        static void max(int x, int y)
        {
            if(x > y)
            {
                Console.WriteLine("1. sayı 2.sayıdan büyüktür.");
            }else if(x < y)
            {
                Console.WriteLine("2. sayı 1. sayıdan büyüktür.");
            }else 
            { 
                Console.WriteLine("");
            }
        }
    }
}
