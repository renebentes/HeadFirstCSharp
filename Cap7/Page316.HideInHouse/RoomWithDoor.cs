namespace Page316.HideInHouse
{
    internal class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        private readonly string doorDescription;

        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription)
            : base(name, decoration, hidingPlaceName)
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

        public Location DoorLocation { get; set; }
    }
}