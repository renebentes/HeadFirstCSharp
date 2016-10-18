using System.Text;

namespace Page316.HideInHouse
{
    internal class Outside : Location
    {
        private bool hot;

        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public bool Hot
        {
            get
            {
                return hot;
            }
        }

        public override string Description
        {
            get
            {
                var description = new StringBuilder(base.Description);
                if (Hot)
                    description.Append("It's very hot here");
                return description.ToString();
            }
        }
    }
}