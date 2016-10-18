namespace Page316.HideInHouse
{
    internal class RoomWithDoor : Room, IHasExteriorDoor
    {
        private string doorDescription;
        private Location doorLocation;

        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration)
        {
            this.doorDescription = doorDescription;
        }

        public string DoorDescription
        {
            get
            {
                return doorDescription;
            }
        }

        public Location DoorLocation
        {
            get
            {
                return doorLocation;
            }

            set
            {
                doorLocation = value;
            }
        }
    }
}