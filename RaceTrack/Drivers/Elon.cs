using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Elon : Driver
    {
        public Elon(RaceCar car) : base(car)
        {
            Name = "Terflon Elon";
            SkillLevel = 50;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
