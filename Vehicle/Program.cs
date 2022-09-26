using System;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a new car
            Car car = new Car();
            car.Make().PrintInfo();

            Console.WriteLine(string.Empty);

            //create a new bus
            Bus bus = new Bus();
            bus.Make().PrintInfo();

            Console.WriteLine();
            Console.Write("Press any key to close the app...");
            Console.ReadKey();

        }
    }
}
