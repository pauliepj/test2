using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeding
{
    class Program
    {/*1. Create a parent class vehicle and add 
        appropriate properties and break(), accelerate ()  methods.
        Create classes Bike and Car which inherit the Vehicle class and have a 
        static property speed. Assign an appropriate value to the speed property 
        in the child classes.*/
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brake(5);
            car.Acceleration(50);
            int cs = car.GetSpeed();
            //test
            Bike bike = new Bike();
            bike.Brake(1);
            bike.Acceleration(30);
            int bs = bike.GetSpeed();
            Console.WriteLine("Bike speed is " + bs);
            Console.ReadLine();
            Console.WriteLine("Car speed is " + cs);
            Console.ReadLine();
        }
    }
}
