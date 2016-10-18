using System;
using System.Windows.Forms;

namespace Page331
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var numberBetween0and3 = random.Next(4);
            var numberBetween1and13 = random.Next(1, 14);

            var card = new Card((Values)numberBetween1and13, (Suits)numberBetween0and3);
            label1.Text = card.Name;
        }
    }
}