using System;

namespace Vehicle
{
    internal class Bus
    {
        //engine params
        const int power = 250;
        const int volume = 3500;
        const string id = "01111B";

        //chassis params
        const int numberOfWheels = 4;
        const int maxLoad = 3500;

        //transmission params
        Transmission.Type type = Transmission.Type.Manual;
        const int gearsNumber = 5;

        Engine engine;
        Chassis chassis;
        Transmission transmission;

        public Bus Make()
        {
            engine = new Engine(power, volume, id);
            chassis = new Chassis(numberOfWheels, maxLoad);
            transmission = new Transmission(type, gearsNumber);
            return this;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Bus information");
            engine.PringInfo();
            chassis.PrintInfo();
            transmission.PrintInfo();
        }
    }

}