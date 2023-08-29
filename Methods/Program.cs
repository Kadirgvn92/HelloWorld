using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumNumber(1, 2));
            Console.WriteLine("------------------------------");
            add("Kadir", "güven");
            Console.WriteLine("------------------------------");
            Console.WriteLine(write("kadirgvn92@gmail.com", "13087846850"));
            Console.WriteLine("------------------------------");
        }

        static int sumNumber(int a, int b)
        {
            int c = a + b;
            return c;
        }

        static void add(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
        
        static string write(string email, string id) 
        { 
            string customer = email + " " + id;
            return customer;
        }
    }
}
