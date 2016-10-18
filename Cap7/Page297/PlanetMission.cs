using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page297
{
    internal abstract class PlanetMission
    {
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet;

        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }

        public int TimeNeeded()
        {
            return MilesToPlanet / (int)RocketSpeedMPH;
        }

        public string FuelNeeded()
        {
            return "You'll need " + RocketFuelPerMile + " units of fuel to get there. It'll take " + TimeNeeded() + " hours.";
        }

        public abstract void SetMissioninfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH);
    }
}