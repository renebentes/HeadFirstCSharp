using System.Text;

namespace Page316.HideInHouse
{
    internal class RoomWithHidingPlace : Room, IHidingPlace
    {
        private readonly string hidingPlaceName;

        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            this.hidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName
        {
            get
            {
                return hidingPlaceName;
            }
        }

        public override string Description
        {
            get
            {
                var description = new StringBuilder(base.Description);
                description.Append(" Someone could hide ");
                description.Append(hidingPlaceName);
                description.Append(".");
                return description.ToString();
            }
        }
    }
}