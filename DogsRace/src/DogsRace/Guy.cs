using System.Windows.Forms;

namespace DogsRace
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        
        public void UpdateLabels()
        {
            MyLabel.Text = MyBet == null ? Name + " hasn't placed a bet" : MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            if (Cash > 0)
            {
                MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }
    }
}
