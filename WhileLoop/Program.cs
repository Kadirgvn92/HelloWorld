using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;
            bool count = true;
            bool count2 = true;

            while (a <= 10) 
            {
                Console.WriteLine(a++);
            }

            Console.WriteLine("-------------------");


            while (b >= 0) 
            {
                if (b % 2 == 0)
                {
                    Console.WriteLine(b);
                }
                b--;
            }
        }
    }
}
