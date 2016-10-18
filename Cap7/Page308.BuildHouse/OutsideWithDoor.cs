using System.Text;

namespace Page316.HideInHouse
{
    internal class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        private string doorDescription;
        private Location doorLocation;

        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
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

        public override string Description
        {
            get
            {
                var description = new StringBuilder(base.Description);
                description.Append("you see ");
                description.Append(doorDescription);
                description.Append(".");
                return description.ToString();
            }
        }
    }
}