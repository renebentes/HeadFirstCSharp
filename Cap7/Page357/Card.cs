namespace Page357
{
    internal class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public string Name
        {
            get
            {
                return Value + " of " + Suit;
            }
        }

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            return cardToCheck.Suit == suit ? true : false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            return cardToCheck.Value == value ? true : false;
        }
    }
}