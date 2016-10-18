using System.Text;

namespace Page316.HideInHouse
{
    internal class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        private readonly string doorDescription;

        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot)
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

        public override string Description
        {
            get
            {
                var description = new StringBuilder(base.Description);
                description.Append(" You see ");
                description.Append(doorDescription);
                description.Append(".");
                return description.ToString();
            }
        }
    }
}