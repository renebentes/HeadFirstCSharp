using System;

namespace Page316.HideInHouse
{
    internal class Opponent
    {
        private Location myLocation;
        private readonly Random random;

        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                var locationWithDoor = myLocation as IHasExteriorDoor;
                if (random.Next(2) == 1)
                    myLocation = locationWithDoor.DoorLocation;
            }

            while (true)
            {
                var rand = random.Next(myLocation.Exists.Length);
                myLocation = myLocation.Exists[rand];
                if (myLocation is IHidingPlace)
                    break;
            }
        }

        public bool Check(Location locationToCheck)
        {
            return locationToCheck == myLocation ? true : false;
        }
    }
}