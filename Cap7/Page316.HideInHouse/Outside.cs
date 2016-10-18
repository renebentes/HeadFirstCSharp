namespace Page316.HideInHouse
{
    internal class Outside : Location
    {
        private readonly bool hot;

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
                var description = base.Description;
                if (Hot)
                    description += " It's very hot.";
                return description;
            }
        }
    }
}