using System.Text;

namespace Page316.HideInHouse
{
    public abstract class Location
    {
        protected Location(string name)
        {
            this.name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        public Location[] Exists;

        public virtual string Description
        {
            get
            {
                var description = new StringBuilder();
                description.Append("You're standing in the " + name + ". You see exits to the following places: ");
                for (int i = 0; i < Exists.Length; i++)
                {
                    description.Append(" " + Exists[i].Name);
                    if (i != Exists.Length - 1)
                        description.Append(", ");
                }
                description.Append(".");
                return description.ToString(); ;
            }
        }
    }
}