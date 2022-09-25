using System;

namespace Vehicle
{
    internal class Chassis
    {
        private int numberOfWheels;
        private int maxLoad;

        public Chassis(int numberOfWheels, int maxLoad)
        {
            this.numberOfWheels = numberOfWheels;
            this.maxLoad = maxLoad;
        }

        internal void PrintInfo()
        {
            Console.WriteLine($"    Number Of Wheels: {numberOfWheels}");
            Console.WriteLine($"    Load: {maxLoad} kg");
        }
    }
}