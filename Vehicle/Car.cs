using System;

namespace Vehicle
{
    internal class Car
    {
        //engine params
        const int power = 150;
        const int volume = 2000;
        const string id = "12345A";

        //chassis params
        const int numberOfWheels = 4;
        const int maxLoad = 1500;

        //transmission params
        Transmission.Type type = Transmission.Type.Automatic;
        const int gearsNumber = 0;

        Engine engine;
        Chassis chassis;
        Transmission transmission;

        public Car Make()
        {
            engine = new Engine(power, volume, id);
            chassis = new Chassis(numberOfWheels, maxLoad);
            transmission = new Transmission(type, gearsNumber);
            return this;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Car information");
            engine.PringInfo();
            chassis.PrintInfo();
            transmission.PrintInfo();
        }
    }
}
