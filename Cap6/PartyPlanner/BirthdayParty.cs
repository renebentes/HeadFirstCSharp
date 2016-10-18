using System.Windows.Forms;

namespace PartyPlanner
{
    public class BirthdayParty : Party
    {
        public int CakeSize = 0;
        private string cakeWriting;

        public string CakeWriting
        {
            get { return cakeWriting; }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;

                if (!string.IsNullOrEmpty(value) && value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " ink cake");
                    cakeWriting = value.Substring(0, maxLength);
                }
                else
                    cakeWriting = value;
            }
        }


        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                CakeWriting = cakeWriting;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting = "")
            : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;
            }
        }

        public override decimal CalculateCost()
        {
            decimal CakeCost;

            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * .25M;
            else
                CakeCost = 75M + CakeWriting.Length * .25M;

            return base.CalculateCost() + CakeCost;
        }


    }
}
