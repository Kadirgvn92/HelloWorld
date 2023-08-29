using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            
            car.startCar();
            car.stopCar();

            car.doorNumber = 4;
            car.carModel = "2012";
            car.carColor = "Red";

            Console.WriteLine(car.carColor);    
            Console.WriteLine(car.carModel);
            Console.WriteLine(car.doorNumber);
        }
    }
}
