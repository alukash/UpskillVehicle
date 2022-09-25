using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Engine
    {
        int power;
        int volume;
        string id;

        public Engine(int power, int volume, string id)
        {
            this.power = power;
            this.volume = volume;
            this.id = id;
        }

        internal void PringInfo()
        {
            Console.WriteLine($"    Engine Id: {id}");
            Console.WriteLine($"    Power: {power} hp");
            Console.WriteLine($"    Volume: {volume} cc");
        }
    }
}
