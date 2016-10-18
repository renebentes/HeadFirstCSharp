using System.Text;

namespace Page316.HideInHouse
{
    public class Room : Location
    {
        private readonly string decoration;

        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                var description = new StringBuilder(base.Description);
                description.Append(" You see ");
                description.Append(decoration);
                description.Append(".");
                return description.ToString();
            }
        }
    }
}