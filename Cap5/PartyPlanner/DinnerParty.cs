namespace PartyPlanner
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        private bool fancyDecorations;
        private int numberOfPeople;

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        public DinnerParty(int numberOfPeople, bool healtyOption, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;

            SetHealthyOption(healtyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healtyOption)
        {
            if (healtyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            this.fancyDecorations = fancyDecoration;
            if (fancyDecoration)
            {
                CostOfDecorations = 15.00M * NumberOfPeople + 50.00M;
            }
            else
            {
                CostOfDecorations = 7.50M * NumberOfPeople + 30.00M;
            }
        }

        public decimal CalculateCost(bool healtyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) + NumberOfPeople);

            if (healtyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
