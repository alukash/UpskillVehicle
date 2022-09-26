using System;

namespace Vehicle
{
    internal class Transmission
    {
        public enum Type
        {
            Automatic,
            Manual
        }

        private Type type;
        private int gearsNumber;

        public Transmission(Type type, int gearsNumber)
        {
            this.type = type;
            this.gearsNumber = gearsNumber;
        }

        internal void PrintInfo()
        {
            string gears = type.Equals(Type.Automatic) ? "N/A" : gearsNumber.ToString();
            Console.WriteLine($"    Type Of Transmission: {type}");
            Console.WriteLine($"    Number Of Gears: {gears}");
        }
    }
}