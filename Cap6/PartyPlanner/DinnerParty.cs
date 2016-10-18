namespace PartyPlanner
{
    public class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healtyOption)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healtyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healtyOption)
        {
            if (healtyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }

        public decimal CalculateCost(bool healtyOption)
        {
            decimal totalCost = CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);

            if (NumberOfPeople > 12)
                totalCost += 100;

            if (healtyOption)
                return totalCost * .95M;
            else
                return totalCost;
        }
    }
}
