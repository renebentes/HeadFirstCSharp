using System.Text;

namespace Page316.HideInHouse
{
    internal class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        private readonly string hidingPlaceName;

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName)
            : base(name, hot)
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