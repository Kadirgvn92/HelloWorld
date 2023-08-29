using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Car
    {
        public int doorNumber;
        public String carModel;
        public String carColor;

        public void startCar() 
        {
            Console.WriteLine("Car has been starting..");
        }

        public void stopCar() 
        {
            Console.WriteLine("Car stoped..");
        }
    }
}
