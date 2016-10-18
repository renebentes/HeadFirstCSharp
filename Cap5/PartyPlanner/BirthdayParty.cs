using System.Windows.Forms;

namespace PartyPlanner
{
    public class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;

        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        public int CakeSize;
        private int numberOfPeople;
        private string cakeWriting = "";

        public string CakeWriting
        {
            get { return this.cakeWriting; }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " ink cake");
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;
            }
        }


        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                CakeWriting = cakeWriting;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            if (fancyDecorations)
                CostOfDecorations = 15.00M * NumberOfPeople + 50.00M;
            else
                CostOfDecorations = 7.50M * NumberOfPeople + 30.00M;
        }

        public decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople) + (NumberOfPeople > 12 ? 100 : 0);
            decimal cakeCost;

            if (CakeSize == 8)
                cakeCost = 40M + CakeWriting.Length * .25M;
            else
                cakeCost = 75M + CakeWriting.Length * .25M;

            return totalCost + cakeCost;
        }


    }
}
