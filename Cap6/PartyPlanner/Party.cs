namespace PartyPlanner
{
    public class Party
    {
        const int CostOfFoodPerPerson = 25;
        private bool fancyDecorations;
        public decimal CostOfDecorations = 0;
        private int numberOfPeople;

        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            this.fancyDecorations = fancyDecoration;
            if (fancyDecoration)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            else
                CostOfDecorations = (NumberOfPeople + 7.50M) + 30.00M;
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);

            if (NumberOfPeople > 12)
                totalCost += 100;

            return totalCost;
        }
    }
}
