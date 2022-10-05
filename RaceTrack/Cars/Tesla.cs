using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Tesla : RaceCar
    {
        public Tesla()
        {
            Name = "Tesla Model S Plaid HACKED";
            TopSpeed = 216;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} sliently powers on");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"Did the {Name} engine turn off?");
        }
    }
}
